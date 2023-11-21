namespace collisionCheckOnForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            object2 = new PictureBox();
            mainTimer = new System.Windows.Forms.Timer(components);
            object1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)object2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)object1).BeginInit();
            SuspendLayout();
            // 
            // object2
            // 
            object2.BackColor = Color.Red;
            object2.Location = new Point(551, 244);
            object2.Name = "object2";
            object2.Size = new Size(172, 157);
            object2.TabIndex = 5;
            object2.TabStop = false;
            object2.Paint += object2_Paint;
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 20;
            mainTimer.Tick += mainTimerEvent;
            // 
            // object1
            // 
            object1.BackColor = Color.Lime;
            object1.Location = new Point(151, 244);
            object1.Name = "object1";
            object1.Size = new Size(172, 157);
            object1.TabIndex = 4;
            object1.TabStop = false;
            object1.Paint += object1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 6;
            label1.Text = "ÇARPIŞMA --??";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(label1);
            Controls.Add(object2);
            Controls.Add(object1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyisDown;
            KeyUp += keyisUp;
            ((System.ComponentModel.ISupportInitialize)object2).EndInit();
            ((System.ComponentModel.ISupportInitialize)object1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox object2;
        private System.Windows.Forms.Timer mainTimer;
        private PictureBox object1;
        private Label label1;
    }
}