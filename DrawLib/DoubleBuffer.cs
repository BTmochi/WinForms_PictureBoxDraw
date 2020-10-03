using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawLib
{

    /// <summary>
    /// ダブルバッファオブジェクトクラス
    /// </summary>
    class DoubleBuffer : IDisposable
    {
        BufferedGraphics myBuffer;
        Control _Control;

        public DoubleBuffer(Control control)
        {
            _Control = control;
            this.Dispose();

            BufferedGraphicsContext currentContext;

            // BufferedGraphicsContextの参照を取得
            currentContext = BufferedGraphicsManager.Current;
            // コントロールに関連付けられたBufferedGraphicsインスタンスを作成します。
            myBuffer = currentContext.Allocate(control.CreateGraphics(),
               control.DisplayRectangle);

            _Control.Paint += new PaintEventHandler(this.Paint);
        }

        ~DoubleBuffer()
        {
            Dispose();
        }

        /// <summary>
        /// バッファの開放を行ってます
        /// </summary>
        public void Dispose()
        {
            if (myBuffer != null)
            {
                myBuffer.Dispose();
                myBuffer = null;
            }
            _Control.Paint -= new PaintEventHandler(this.Paint);
        }

        // 描画処理
        private void Paint(object sender, PaintEventArgs e)
        {
            Refresh();
        }

        // 再描画
        public void Refresh()
        {
            if (myBuffer != null)
                myBuffer.Render();
        }

        /// <summary>
        /// Graphicsオブジェクトの取得
        /// </summary>
        public Graphics getGraphics
        {
            get { return myBuffer.Graphics; }
        }
    }
}
