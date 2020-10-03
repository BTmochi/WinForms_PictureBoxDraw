using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DrawLib
{
    /// <summary>
    /// 描画関連クラス
    /// </summary>
    public class DrawCommon
    {
        /// <summary>
        /// シングルトン
        /// </summary>
        private static DrawCommon _singleInstance = new DrawCommon();

        /// <summary>
        /// インスタンス取得
        /// </summary>
        /// <returns> インスタンス </returns>
        public static DrawCommon GetInstance()
        {
            return _singleInstance;
        }

        public void DrawImage(ref Graphics g, Bitmap bmp, Matrix mat)
        {
            if ((g == null) || (bmp == null)) return;

            // 画像の画素の外側の領域
            var srcRect = new RectangleF(-0.5f, -0.5f, bmp.Width, bmp.Height);

            // 画像の左上、右上、左下の座標
            var points = new PointF[] {
            new PointF(srcRect.Left, srcRect.Top),  // 左上
            new PointF(srcRect.Right, srcRect.Top), // 右上
            new PointF(srcRect.Left, srcRect.Bottom)// 左下
            };

            // アフィン変換で描画先の座標に変換する
            mat.TransformPoints(points);



            // 描画
            g.DrawImage(
                bmp,
                points,
                srcRect,
                GraphicsUnit.Pixel
                );
        }

        public void ScaleAt(ref Matrix mat, float scale, PointF center)
        {
            // 原点へ移動
            mat.Translate(-center.X, -center.Y, MatrixOrder.Append);

            // 拡大縮小
            mat.Scale(scale, scale, MatrixOrder.Append);

            // 元へ戻す
            mat.Translate(center.X, center.Y, MatrixOrder.Append);

        }

        public void ZoomFit(ref Matrix mat, PictureBox pic, Bitmap bmp)
        {
            if (bmp == null) return;

            // アフィン変換行列の初期化（単位行列へ）
            mat.Reset();

            // 0.5画素分移動
            //mat.Translate(0.5f, 0.5f, MatrixOrder.Append);

            int srcWidth = bmp.Width;
            int srcHeight = bmp.Height;
            int dstWidth = pic.Width;
            int dstHeight = pic.Height;

            float scale;

            // 縦に合わせるか？横に合わせるか？
            if (srcHeight * dstWidth > dstHeight * srcWidth)
            {
                // ピクチャボックスの縦方法に画像表示を合わせる場合
                scale = dstHeight / (float)srcHeight;
                mat.Scale(scale, scale, MatrixOrder.Append);
                // 左上に移動
                mat.Translate(0f, 0f, MatrixOrder.Append);
            }
            else
            {
                // ピクチャボックスの横方法に画像表示を合わせる場合
                scale = dstWidth / (float)srcWidth;
                mat.Scale(scale, scale, MatrixOrder.Append);
                // 左上に移動
                mat.Translate(0f, 0f, MatrixOrder.Append);
            }
        }
    }
}
