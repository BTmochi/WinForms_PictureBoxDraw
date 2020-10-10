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
        /// <summary> 基のBitmap </summary> 
        private Bitmap m_OriginBitmap = null;

        /// <summary> 2値化Bitmap </summary> 
        private Bitmap m_BinaryzationBitmap = null;

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
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        }

        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawTestForm_Load(object sender, EventArgs e)
        {
            // 行列の初期化
            m_Mat = new Matrix();

            // ホイールイベントの追加
            this.PictureBox_Orizin.MouseWheel
                += new MouseEventHandler(this.pictureBox_MouseWheel);
            this.PictureBox_Binaryzation.MouseWheel
                += new MouseEventHandler(this.pictureBox_MouseWheel);
        }

        /// <summary>
        /// フォームリサイズ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawTestForm_Resize(object sender, EventArgs e)
        {
            // 描画
            pictureBox_Invalidate();
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
                // ファイルパス取得
                string imageFile = ($@"{openFileDialog.FileName}");
                try
                {
                    // 指定ファイルからImage作成
                    Image image = Image.FromFile(imageFile);

                    // 基となるBitmapに指定
                    m_OriginBitmap = (Bitmap)image;
                    DrawCommon.GetInstance().ZoomFit(ref m_Mat, PictureBox_Orizin, m_OriginBitmap);

                    // Bitmapの2値化
                    m_BinaryzationBitmap = (Bitmap)image;
                    m_BinaryzationBitmap = DrawCommon.GetInstance().CreateNegativeImage(m_BinaryzationBitmap, 0.5f);
                    DrawCommon.GetInstance().ZoomFit(ref m_Mat, PictureBox_Binaryzation, m_BinaryzationBitmap);

                    // 描画
                    pictureBox_Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"画像の読み込みに失敗しました。\n{ex.Message}");
                }
            }
        }

        /// <summary>
        /// 画像ダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            // 画像をピクチャボックスに合わせる
            DrawCommon.GetInstance().ZoomFit(ref m_Mat, PictureBox_Orizin, m_OriginBitmap);

            // 画像の描画
            ((PictureBox)sender).Invalidate();
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
                ((PictureBox)sender).Invalidate();

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
            ((PictureBox)sender).Focus();
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
            ((PictureBox)sender).Invalidate();
        }

        /// <summary>
        /// PictureBoxの描画
        /// </summary>
        private void pictureBox_Invalidate()
        {
            PictureBox_Orizin.Invalidate();
            PictureBox_Binaryzation.Invalidate();
        }

        /// <summary>
        /// 描画イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Bitmap drawBmp = null ;

            switch (((PictureBox)sender).Name)
            {
                case nameof(PictureBox_Orizin):
                    drawBmp = m_OriginBitmap;
                    break;
                case nameof(PictureBox_Binaryzation):
                    drawBmp = m_BinaryzationBitmap;
                    break;
            }

            // 画像描画
            if (drawBmp != null)
            {
                DrawCommon.GetInstance().DrawImage(e.Graphics, drawBmp, m_Mat);
            }
        }
    }
}
