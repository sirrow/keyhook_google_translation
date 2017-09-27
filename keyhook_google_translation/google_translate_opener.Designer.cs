namespace keyhook_google_translation
{
	partial class google_translation_opener
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(google_translation_opener));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enjaToolStripMenuItem,
            this.jaenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // enjaToolStripMenuItem
            // 
            this.enjaToolStripMenuItem.Name = "enjaToolStripMenuItem";
            this.enjaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.enjaToolStripMenuItem.Text = "en->ja";
            this.enjaToolStripMenuItem.Click += new System.EventHandler(this.enjaToolStripMenuItem_Click);
            // 
            // jaenToolStripMenuItem
            // 
            this.jaenToolStripMenuItem.Name = "jaenToolStripMenuItem";
            this.jaenToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.jaenToolStripMenuItem.Text = "ja->en";
            this.jaenToolStripMenuItem.Click += new System.EventHandler(this.jaenToolStripMenuItem_Click);
            // 
            // google_translation_opener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "google_translation_opener";
            this.Text = "google_translation_opener";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jaenToolStripMenuItem;
    }
}

