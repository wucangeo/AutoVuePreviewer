namespace Previewer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AxJVueAXControl1 = new AxJVueAXLib.AxJVueAXControl();
            this.SuspendLayout();

            //
            // AxJVueAXControl1
            //
            this.AxJVueAXControl1.Location = new System.Drawing.Point(0, 0);
            this.AxJVueAXControl1.Name = "AxJVueAXControl1";
            //this.AxJVueAXControl1.OcxState = CType(resources.GetObject("AxJVueAXControl1.OcxState"), System.Windows.Forms.AxHost.State);
            this.AxJVueAXControl1.TabIndex = 1;
            this.AxJVueAXControl1.Dock = System.Windows.Forms.DockStyle.Fill;            
            
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 470);
            this.Controls.Add(this.AxJVueAXControl1);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "文件预览";
            this.Visible = false;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += FormMain_FormClosing;
            this.ResumeLayout(false);
        }


        #endregion

        private AxJVueAXLib.AxJVueAXControl AxJVueAXControl1;
    }
}