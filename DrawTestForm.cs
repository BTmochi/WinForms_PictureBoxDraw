using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DrawLib;

namespace WinForms_PictureBoxDraw
{
    public partial class DrawTestForm : Form
    {
        /// <summary> ダブルバッファオブジェクト </summary>
        private DoubleBuffer m_DoubleBuffer;

        /// <summary> 表示Bitmap </summary> 
        private Bitmap m_Bitmap = null;

        /// <summary> 描画用Graphics </summary>
        Graphics graphics;

        /// <summary> マウスダウンフラグ </summary>
        private bool m_MouseDownFlg = false;

        /// <summary> マウスをクリックした位置の保持用 </summary>
        private PointF m_OldPoint;

        /// <summary> アフィン変換行列 </summary>
        private Matrix m_Mat;

        private const float m_WheelScale = 1.5f;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DrawTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawTestForm_Load(object sender, EventArgs e)
        {
            // Graphicsオブジェクト作成
            //CreateGraphics(pictureBox, ref graphics);

            // DoubleBufferオブジェクトの作成
            m_DoubleBuffer = new DoubleBuffer(pictureBox);

            // 行列の初期化
            m_Mat = new Matrix();

            // ホイールイベントの追加
            this.pictureBox.MouseWheel
                += new MouseEventHandler(this.pictureBox_MouseWheel);
        }

        /// <summary>
        /// フォームリサイズ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawTestForm_Resize(object sender, EventArgs e)
        {
            // Graphicsオブジェクト作成
            //CreateGraphics(pictureBox, ref graphics);

            // リサイズ時は再確保
            if (m_DoubleBuffer != null) m_DoubleBuffer.Dispose();
            m_DoubleBuffer = new DoubleBuffer(pictureBox);

            RedrawImage();
        }

        /// <summary>
        /// フォームクローズ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 解放
            m_DoubleBuffer.Dispose();
        }

        /// <summary>
        /// 画像読み込みボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            //ダイアログを表示する
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageFile = ($@"{openFileDialog.FileName}");
                try
                {
                    Image image = Image.FromFile(imageFile);
                    m_Bitmap = (Bitmap)image;
                    DrawCommon.GetInstance().ZoomFit(ref m_Mat, pictureBox, m_Bitmap);
                    RedrawImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"画像の読み込みに失敗しました。\n{ex.Message}");
                }
            }
        }

        /// <summary>
        /// 画像の描画
        /// </summary>
        private void RedrawImage()
        {
            // Graphicsオブジェクトの取得
            graphics = m_DoubleBuffer.getGraphics;

            // 背景の消去
            graphics.Clear(pictureBox.BackColor);

            // 補間モード設定
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // 画像描画
            DrawCommon.GetInstance().DrawImage(ref graphics, m_Bitmap, m_Mat);


            // Penで描画
            Pen p = Pens.Red;
            for (int X = 0; X < Width; X += 100)
            {
                graphics.DrawLine(p, X, 0, X, Height);
            }

            for (int Y = 0; Y < Height; Y += 100)
            {
                graphics.DrawLine(p, 0, Y, Width, Y);
            }

            // 更新
            m_DoubleBuffer.Refresh();
        }

        /// <summary>
        /// 画像ダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            // 画像をピクチャボックスに合わせる
            DrawCommon.GetInstance().ZoomFit(ref m_Mat, pictureBox, m_Bitmap);

            // 画像の描画
            RedrawImage();
        }

        /// <summary>
        /// 画像移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // マウスをクリックしながら移動中のとき、画像の移動
            if (m_MouseDownFlg == true)
            {
                // 画像の移動
                m_Mat.Translate(e.X - m_OldPoint.X, e.Y - m_OldPoint.Y, MatrixOrder.Append);
                // 画像の描画
                RedrawImage();

                // ポインタ位置の保持
                m_OldPoint.X = e.X;
                m_OldPoint.Y = e.Y;
            }


            // アフィン変換行列（画像座標→ピクチャボックス座標）の逆行列(ピクチャボックス座標→画像座標)を求める
            // Invertで元の行列が上書きされるため、Cloneを取ってから逆行列
            var invert = m_Mat.Clone();
            invert.Invert();

            var pf = new PointF[] { e.Location };

            // ピクチャボックス座標を画像座標に変換する
            invert.TransformPoints(pf);
        }

        /// <summary>
        /// 画像上でのクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox.Focus();
            m_OldPoint.X = e.X;
            m_OldPoint.Y = e.Y;

            m_MouseDownFlg = true;
        }

        /// <summary>
        /// 画像上でのクリック解除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            m_MouseDownFlg = false;
        }

        /// <summary>
        /// 画像上でホイール
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                // 拡大
                if (m_Mat.Elements[0] < 100)  // X方向の倍率を代表してチェック
                {
                    // ポインタの位置周りに拡大
                    DrawCommon.GetInstance().ScaleAt(ref m_Mat, m_WheelScale, e.Location);
                }
            }
            else
            {
                // 縮小
                if (m_Mat.Elements[0] > 0.01)  // X方向の倍率を代表してチェック
                {
                    // ポインタの位置周りに縮小
                    DrawCommon.GetInstance().ScaleAt(ref m_Mat, 1.0f / m_WheelScale, e.Location);
                }
            }
            // 画像の描画
            RedrawImage();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
