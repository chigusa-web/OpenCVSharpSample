namespace OpenCVSharpSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.b_sample1 = new System.Windows.Forms.Button();
            this.b_grayscale = new System.Windows.Forms.Button();
            this.b_template1 = new System.Windows.Forms.Button();
            this.b_template2 = new System.Windows.Forms.Button();
            this.b_face = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_sample1
            // 
            this.b_sample1.Location = new System.Drawing.Point(44, 23);
            this.b_sample1.Name = "b_sample1";
            this.b_sample1.Size = new System.Drawing.Size(207, 82);
            this.b_sample1.TabIndex = 0;
            this.b_sample1.Text = "基本";
            this.b_sample1.UseVisualStyleBackColor = true;
            this.b_sample1.Click += new System.EventHandler(this.B_sample1_Click);
            // 
            // b_grayscale
            // 
            this.b_grayscale.Location = new System.Drawing.Point(44, 123);
            this.b_grayscale.Name = "b_grayscale";
            this.b_grayscale.Size = new System.Drawing.Size(207, 82);
            this.b_grayscale.TabIndex = 1;
            this.b_grayscale.Text = "グレースケール";
            this.b_grayscale.UseVisualStyleBackColor = true;
            this.b_grayscale.Click += new System.EventHandler(this.B_grayscale_Click);
            // 
            // b_template1
            // 
            this.b_template1.Location = new System.Drawing.Point(44, 224);
            this.b_template1.Name = "b_template1";
            this.b_template1.Size = new System.Drawing.Size(207, 82);
            this.b_template1.TabIndex = 2;
            this.b_template1.Text = "テンプレートマッチ1";
            this.b_template1.UseVisualStyleBackColor = true;
            this.b_template1.Click += new System.EventHandler(this.B_template1_Click);
            // 
            // b_template2
            // 
            this.b_template2.Location = new System.Drawing.Point(44, 331);
            this.b_template2.Name = "b_template2";
            this.b_template2.Size = new System.Drawing.Size(207, 82);
            this.b_template2.TabIndex = 3;
            this.b_template2.Text = "テンプレートマッチ2";
            this.b_template2.UseVisualStyleBackColor = true;
            this.b_template2.Click += new System.EventHandler(this.B_template2_Click);
            // 
            // b_face
            // 
            this.b_face.Location = new System.Drawing.Point(286, 23);
            this.b_face.Name = "b_face";
            this.b_face.Size = new System.Drawing.Size(207, 82);
            this.b_face.TabIndex = 4;
            this.b_face.Text = "顔認識";
            this.b_face.UseVisualStyleBackColor = true;
            this.b_face.Click += new System.EventHandler(this.B_face_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_face);
            this.Controls.Add(this.b_template2);
            this.Controls.Add(this.b_template1);
            this.Controls.Add(this.b_grayscale);
            this.Controls.Add(this.b_sample1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_sample1;
        private System.Windows.Forms.Button b_grayscale;
        private System.Windows.Forms.Button b_template1;
        private System.Windows.Forms.Button b_template2;
        private System.Windows.Forms.Button b_face;
    }
}

