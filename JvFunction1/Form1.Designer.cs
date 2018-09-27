namespace JvFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axJVLink1 = new AxJVDTLabLib.AxJVLink();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.returncode = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kokura = new System.Windows.Forms.Button();
            this.chukyo = new System.Windows.Forms.Button();
            this.hanshin = new System.Windows.Forms.Button();
            this.kyoto = new System.Windows.Forms.Button();
            this.hakodate = new System.Windows.Forms.Button();
            this.sapporo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fukushima = new System.Windows.Forms.Button();
            this.nakayama = new System.Windows.Forms.Button();
            this.tokyo = new System.Windows.Forms.Button();
            this.niigata = new System.Windows.Forms.PictureBox();
            this.Kaisai3 = new System.Windows.Forms.Label();
            this.Kaisai2 = new System.Windows.Forms.Label();
            this.Kaisai1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axJVLink2 = new AxJVDTLabLib.AxJVLink();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niigata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink2)).BeginInit();
            this.SuspendLayout();
            // 
            // axJVLink1
            // 
            this.axJVLink1.Enabled = true;
            this.axJVLink1.Location = new System.Drawing.Point(191, 116);
            this.axJVLink1.Name = "axJVLink1";
            this.axJVLink1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axJVLink1.OcxState")));
            this.axJVLink1.Size = new System.Drawing.Size(192, 192);
            this.axJVLink1.TabIndex = 0;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 509);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.Size = new System.Drawing.Size(668, 22);
            this.statusBar1.TabIndex = 47;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 143);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 19);
            this.textBox2.TabIndex = 46;
            // 
            // returncode
            // 
            this.returncode.AutoSize = true;
            this.returncode.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.returncode.Location = new System.Drawing.Point(626, 12);
            this.returncode.Name = "returncode";
            this.returncode.Size = new System.Drawing.Size(0, 18);
            this.returncode.TabIndex = 45;
            this.returncode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returncode.UseCompatibleTextRendering = true;
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.info1.Location = new System.Drawing.Point(54, 89);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(241, 19);
            this.info1.TabIndex = 44;
            this.info1.Text = "開催情報を取得していません。";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // kokura
            // 
            this.kokura.Enabled = false;
            this.kokura.Location = new System.Drawing.Point(143, 353);
            this.kokura.Name = "kokura";
            this.kokura.Size = new System.Drawing.Size(75, 23);
            this.kokura.TabIndex = 42;
            this.kokura.Text = "小倉競馬場";
            this.kokura.UseVisualStyleBackColor = true;
            // 
            // chukyo
            // 
            this.chukyo.Enabled = false;
            this.chukyo.Location = new System.Drawing.Point(381, 353);
            this.chukyo.Name = "chukyo";
            this.chukyo.Size = new System.Drawing.Size(75, 23);
            this.chukyo.TabIndex = 41;
            this.chukyo.Text = "中京競馬場";
            this.chukyo.UseVisualStyleBackColor = true;
            // 
            // hanshin
            // 
            this.hanshin.Enabled = false;
            this.hanshin.Location = new System.Drawing.Point(291, 347);
            this.hanshin.Name = "hanshin";
            this.hanshin.Size = new System.Drawing.Size(75, 23);
            this.hanshin.TabIndex = 40;
            this.hanshin.Text = "阪神競馬場";
            this.hanshin.UseVisualStyleBackColor = true;
            // 
            // kyoto
            // 
            this.kyoto.Enabled = false;
            this.kyoto.Location = new System.Drawing.Point(314, 318);
            this.kyoto.Name = "kyoto";
            this.kyoto.Size = new System.Drawing.Size(75, 23);
            this.kyoto.TabIndex = 39;
            this.kyoto.Text = "京都競馬場";
            this.kyoto.UseVisualStyleBackColor = true;
            // 
            // hakodate
            // 
            this.hakodate.Enabled = false;
            this.hakodate.Location = new System.Drawing.Point(437, 124);
            this.hakodate.Name = "hakodate";
            this.hakodate.Size = new System.Drawing.Size(75, 23);
            this.hakodate.TabIndex = 38;
            this.hakodate.Text = "函館競馬場";
            this.hakodate.UseVisualStyleBackColor = true;
            // 
            // sapporo
            // 
            this.sapporo.Enabled = false;
            this.sapporo.Location = new System.Drawing.Point(493, 74);
            this.sapporo.Name = "sapporo";
            this.sapporo.Size = new System.Drawing.Size(75, 23);
            this.sapporo.TabIndex = 37;
            this.sapporo.Text = "札幌競馬場";
            this.sapporo.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(407, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "新潟競馬場";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // fukushima
            // 
            this.fukushima.Enabled = false;
            this.fukushima.Location = new System.Drawing.Point(531, 262);
            this.fukushima.Name = "fukushima";
            this.fukushima.Size = new System.Drawing.Size(75, 23);
            this.fukushima.TabIndex = 35;
            this.fukushima.Text = "福島競馬場";
            this.fukushima.UseVisualStyleBackColor = true;
            // 
            // nakayama
            // 
            this.nakayama.Enabled = false;
            this.nakayama.Location = new System.Drawing.Point(531, 318);
            this.nakayama.Name = "nakayama";
            this.nakayama.Size = new System.Drawing.Size(75, 23);
            this.nakayama.TabIndex = 34;
            this.nakayama.Text = "中山競馬場";
            this.nakayama.UseVisualStyleBackColor = true;
            // 
            // tokyo
            // 
            this.tokyo.Enabled = false;
            this.tokyo.Location = new System.Drawing.Point(462, 353);
            this.tokyo.Name = "tokyo";
            this.tokyo.Size = new System.Drawing.Size(75, 23);
            this.tokyo.TabIndex = 33;
            this.tokyo.Text = "東京競馬場";
            this.tokyo.UseVisualStyleBackColor = true;
            // 
            // niigata
            // 
            this.niigata.ErrorImage = ((System.Drawing.Image)(resources.GetObject("niigata.ErrorImage")));
            this.niigata.Image = ((System.Drawing.Image)(resources.GetObject("niigata.Image")));
            this.niigata.Location = new System.Drawing.Point(0, 54);
            this.niigata.Name = "niigata";
            this.niigata.Size = new System.Drawing.Size(665, 430);
            this.niigata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.niigata.TabIndex = 32;
            this.niigata.TabStop = false;
            // 
            // Kaisai3
            // 
            this.Kaisai3.AutoSize = true;
            this.Kaisai3.Location = new System.Drawing.Point(162, 60);
            this.Kaisai3.Name = "Kaisai3";
            this.Kaisai3.Size = new System.Drawing.Size(0, 12);
            this.Kaisai3.TabIndex = 31;
            // 
            // Kaisai2
            // 
            this.Kaisai2.AutoSize = true;
            this.Kaisai2.Location = new System.Drawing.Point(162, 39);
            this.Kaisai2.Name = "Kaisai2";
            this.Kaisai2.Size = new System.Drawing.Size(0, 12);
            this.Kaisai2.TabIndex = 30;
            // 
            // Kaisai1
            // 
            this.Kaisai1.AutoSize = true;
            this.Kaisai1.Location = new System.Drawing.Point(162, 18);
            this.Kaisai1.Name = "Kaisai1";
            this.Kaisai1.Size = new System.Drawing.Size(0, 12);
            this.Kaisai1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "本日の開催";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(285, 178);
            this.textBox1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axJVLink2
            // 
            this.axJVLink2.Enabled = true;
            this.axJVLink2.Location = new System.Drawing.Point(224, 318);
            this.axJVLink2.Name = "axJVLink2";
            this.axJVLink2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axJVLink2.OcxState")));
            this.axJVLink2.Size = new System.Drawing.Size(192, 192);
            this.axJVLink2.TabIndex = 25;
            this.axJVLink2.JVEvtPay += new AxJVDTLabLib._IJVLinkEvents_JVEvtPayEventHandler(this.axJVLink2_JVEvtPay);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "JvLink設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.returncode);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.kokura);
            this.Controls.Add(this.chukyo);
            this.Controls.Add(this.hanshin);
            this.Controls.Add(this.kyoto);
            this.Controls.Add(this.hakodate);
            this.Controls.Add(this.sapporo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fukushima);
            this.Controls.Add(this.nakayama);
            this.Controls.Add(this.tokyo);
            this.Controls.Add(this.niigata);
            this.Controls.Add(this.Kaisai3);
            this.Controls.Add(this.Kaisai2);
            this.Controls.Add(this.Kaisai1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axJVLink2);
            this.Controls.Add(this.axJVLink1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niigata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxJVDTLabLib.AxJVLink axJVLink1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label returncode;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button kokura;
        private System.Windows.Forms.Button chukyo;
        private System.Windows.Forms.Button hanshin;
        private System.Windows.Forms.Button kyoto;
        private System.Windows.Forms.Button hakodate;
        private System.Windows.Forms.Button sapporo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button fukushima;
        private System.Windows.Forms.Button nakayama;
        private System.Windows.Forms.Button tokyo;
        private System.Windows.Forms.PictureBox niigata;
        private System.Windows.Forms.Label Kaisai3;
        private System.Windows.Forms.Label Kaisai2;
        private System.Windows.Forms.Label Kaisai1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private AxJVDTLabLib.AxJVLink axJVLink2;
        private System.Windows.Forms.Button button2;
    }
}

