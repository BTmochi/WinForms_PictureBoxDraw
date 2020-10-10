using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;
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

        /// <summary>
        /// 描画処理　(OnPaintで呼ぶこと)
        /// </summary>
        /// <param name="g">OnPaintで取得したイベントのグラフィックス(e.Graphics)</param>
        /// <param name="bmp">ビットマップ</param>
        /// <param name="mat">変換行列</param>
        public void DrawImage(Graphics g, Bitmap bmp, Matrix mat)
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

            // 補間モードの設定
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            // 描画
            g.DrawImage(
                bmp,
                points,
                srcRect,
                GraphicsUnit.Pixel
                );
        }

        /// <summary>
        /// スケーリング
        /// </summary>
        /// <param name="mat">変換行列</param>
        /// <param name="scale">スケール値</param>
        /// <param name="center">スケーリングする画像の中心点</param>
        public void ScaleAt(ref Matrix mat, float scale, PointF center)
        {
            // 原点へ移動
            mat.Translate(-center.X, -center.Y, MatrixOrder.Append);

            // 拡大縮小
            mat.Scale(scale, scale, MatrixOrder.Append);

            // 元へ戻す
            mat.Translate(center.X, center.Y, MatrixOrder.Append);

        }

        /// <summary>
        /// 描画先に合わせて画像をスケーリング
        /// </summary>
        /// <param name="mat">変換行列</param>
        /// <param name="pic">描画先のPictureBox</param>
        /// <param name="bmp">ビットマップ</param>
        public void ZoomFit(ref Matrix mat, PictureBox pic, Bitmap bmp)
        {
            if (bmp == null) return;

            // アフィン変換行列の初期化（単位行列へ）
            mat.Reset();

            int srcWidth = bmp.Width;
            int srcHeight = bmp.Height;
            int dstWidth = pic.Width;
            int dstHeight = pic.Height;

            float scale;

            // 縦、横方向の算出
            if (srcHeight * dstWidth > dstHeight * srcWidth)
            {
                // 縦方法に画像表示を合わせる場合
                scale = dstHeight / (float)srcHeight;
                mat.Scale(scale, scale, MatrixOrder.Append);
                // 左上に移動
                mat.Translate(0f, 0f, MatrixOrder.Append);
            }
            else
            {
                // 横方法に画像表示を合わせる場合
                scale = dstWidth / (float)srcWidth;
                mat.Scale(scale, scale, MatrixOrder.Append);
                // 左上に移動
                mat.Translate(0f, 0f, MatrixOrder.Append);
            }
        }

        /// <summary>
        /// 2値化
        /// </summary>
        /// <param name="bmp">ビットマップ</param>
        /// <param name="threshold">しきい値</param>
        /// <returns>2値化画像</returns>
        public Bitmap CreateNegativeImage(Bitmap bmp,float threshold)
        {
            //1bppイメージを作成する
            Bitmap newImg = new Bitmap(bmp.Width, bmp.Height,
                PixelFormat.Format1bppIndexed);

            //Bitmapをロックする
            BitmapData bmpDate = newImg.LockBits(
                new Rectangle(0, 0, newImg.Width, newImg.Height),
                ImageLockMode.ReadWrite, newImg.PixelFormat);

            unsafe
            {
                byte* pixelPtr = (byte*)bmpDate.Scan0;
                for (int y = 0; y < bmpDate.Height; y++)
                {
                    for (int x = 0; x < bmpDate.Width; x++)
                    {
                        //明るさがしきい値以上の時は白くする
                        if (threshold <= bmp.GetPixel(x, y).GetBrightness())
                        {
                            //ピクセルデータの位置
                            int pos = (x >> 3) + bmpDate.Stride * y;
                            //白くする
                            pixelPtr[pos] |= (byte)(0x80 >> (x & 0x7));
                        }
                    }
                }
            }

            //ロックを解除する
            newImg.UnlockBits(bmpDate);

            return newImg;

        }
    }
}
