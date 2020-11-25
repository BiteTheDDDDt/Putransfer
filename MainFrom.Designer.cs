using System.Collections;
namespace Putransfer
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonBackTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSwap = new System.Windows.Forms.Button();
            this.ButtonTrim = new System.Windows.Forms.Button();
            this.ButtonTransfer = new System.Windows.Forms.Button();
            this.ButtonTransferLeft = new System.Windows.Forms.Button();
            this.ButtonTransferLeftLeft = new System.Windows.Forms.Button();
            this.ButtonTransferRight = new System.Windows.Forms.Button();
            this.ButtonTransferRightRight = new System.Windows.Forms.Button();
            this.ButtonSwapTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonTrimTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonTransferTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonLeftTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonLeftLeftTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonRightTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonRightRightTip = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1Tip = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar2Tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNew
            // 
            this.textBoxNew.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxNew.Location = new System.Drawing.Point(777, 12);
            this.textBoxNew.Multiline = true;
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(473, 710);
            this.textBoxNew.TabIndex = 0;
            // 
            // textBoxOld
            // 
            this.textBoxOld.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxOld.Location = new System.Drawing.Point(12, 12);
            this.textBoxOld.Multiline = true;
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(473, 710);
            this.textBoxOld.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(532, 69);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 172);
            this.trackBar1.TabIndex = 0;
            this.ButtonBackTip.SetToolTip(this.trackBar1, "原调");
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(695, 69);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(56, 172);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ButtonBackTip.SetToolTip(this.trackBar2, "变调");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Putransfer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(489, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 104);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Provided by BiteTheDDDDt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(160, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "v0.11";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Putransfer.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(214, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 67);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonBack.Image = global::Putransfer.Properties.Resources.Open_6296;
            this.ButtonBack.Location = new System.Drawing.Point(489, 367);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(138, 60);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBackTip.SetToolTip(this.ButtonBack, "回退");
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSwap
            // 
            this.ButtonSwap.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonSwap.Image = global::Putransfer.Properties.Resources.LayerDiagramfile_layerdiagram_13450;
            this.ButtonSwap.Location = new System.Drawing.Point(633, 367);
            this.ButtonSwap.Name = "ButtonSwap";
            this.ButtonSwap.Size = new System.Drawing.Size(138, 60);
            this.ButtonSwap.TabIndex = 7;
            this.ButtonBackTip.SetToolTip(this.ButtonSwap, "交换左右文本");
            this.ButtonSwap.UseVisualStyleBackColor = true;
            this.ButtonSwap.Click += new System.EventHandler(this.ButtonSwap_Click);
            // 
            // ButtonTrim
            // 
            this.ButtonTrim.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonTrim.Image = global::Putransfer.Properties.Resources.RegistryEditor_5838_32x;
            this.ButtonTrim.Location = new System.Drawing.Point(633, 433);
            this.ButtonTrim.Name = "ButtonTrim";
            this.ButtonTrim.Size = new System.Drawing.Size(138, 60);
            this.ButtonTrim.TabIndex = 15;
            this.ButtonBackTip.SetToolTip(this.ButtonTrim, "格式化文本");
            this.ButtonTrim.UseVisualStyleBackColor = true;
            // 
            // ButtonTransfer
            // 
            this.ButtonTransfer.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonTransfer.Image = global::Putransfer.Properties.Resources.FillTool_204;
            this.ButtonTransfer.Location = new System.Drawing.Point(572, 301);
            this.ButtonTransfer.Name = "ButtonTransfer";
            this.ButtonTransfer.Size = new System.Drawing.Size(118, 60);
            this.ButtonTransfer.TabIndex = 2;
            this.ButtonBackTip.SetToolTip(this.ButtonTransfer, "转调");
            this.ButtonTransfer.UseVisualStyleBackColor = true;
            this.ButtonTransfer.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonTransferLeft
            // 
            this.ButtonTransferLeft.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonTransferLeft.Image = global::Putransfer.Properties.Resources.MovePrevious_7195;
            this.ButtonTransferLeft.Location = new System.Drawing.Point(532, 301);
            this.ButtonTransferLeft.Name = "ButtonTransferLeft";
            this.ButtonTransferLeft.Size = new System.Drawing.Size(35, 60);
            this.ButtonTransferLeft.TabIndex = 6;
            this.ButtonBackTip.SetToolTip(this.ButtonTransferLeft, "降半音");
            this.ButtonTransferLeft.UseVisualStyleBackColor = true;
            // 
            // ButtonTransferLeftLeft
            // 
            this.ButtonTransferLeftLeft.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonTransferLeftLeft.Image = global::Putransfer.Properties.Resources.NavigateBackwards_6270;
            this.ButtonTransferLeftLeft.Location = new System.Drawing.Point(491, 301);
            this.ButtonTransferLeftLeft.Name = "ButtonTransferLeftLeft";
            this.ButtonTransferLeftLeft.Size = new System.Drawing.Size(35, 60);
            this.ButtonTransferLeftLeft.TabIndex = 3;
            this.ButtonBackTip.SetToolTip(this.ButtonTransferLeftLeft, "降八度");
            this.ButtonTransferLeftLeft.UseVisualStyleBackColor = true;
            this.ButtonTransferLeftLeft.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ButtonTransferRight
            // 
            this.ButtonTransferRight.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonTransferRight.Image = global::Putransfer.Properties.Resources.GotoNextRow_289;
            this.ButtonTransferRight.Location = new System.Drawing.Point(695, 301);
            this.ButtonTransferRight.Name = "ButtonTransferRight";
            this.ButtonTransferRight.Size = new System.Drawing.Size(35, 60);
            this.ButtonTransferRight.TabIndex = 5;
            this.ButtonBackTip.SetToolTip(this.ButtonTransferRight, "升半音");
            this.ButtonTransferRight.UseVisualStyleBackColor = true;
            // 
            // ButtonTransferRightRight
            // 
            this.ButtonTransferRightRight.Font = new System.Drawing.Font("黑体", 20F);
            this.ButtonTransferRightRight.Image = global::Putransfer.Properties.Resources.NavigateForward_6271;
            this.ButtonTransferRightRight.Location = new System.Drawing.Point(736, 301);
            this.ButtonTransferRightRight.Name = "ButtonTransferRightRight";
            this.ButtonTransferRightRight.Size = new System.Drawing.Size(35, 60);
            this.ButtonTransferRightRight.TabIndex = 4;
            this.ButtonBackTip.SetToolTip(this.ButtonTransferRightRight, "升八度");
            this.ButtonTransferRightRight.UseVisualStyleBackColor = true;
            this.ButtonTransferRightRight.Click += new System.EventHandler(this.ButtonTransferRight_Click);
            // 
            // ButtonSwapTip
            // 
            this.ButtonSwapTip.IsBalloon = true;
            // 
            // ButtonTrimTip
            // 
            this.ButtonTrimTip.IsBalloon = true;
            // 
            // ButtonTransferTip
            // 
            this.ButtonTransferTip.IsBalloon = true;
            // 
            // ButtonLeftTip
            // 
            this.ButtonLeftTip.IsBalloon = true;
            // 
            // ButtonLeftLeftTip
            // 
            this.ButtonLeftLeftTip.IsBalloon = true;
            // 
            // ButtonRightTip
            // 
            this.ButtonRightTip.IsBalloon = true;
            // 
            // ButtonRightRightTip
            // 
            this.ButtonRightRightTip.IsBalloon = true;
            // 
            // trackBar1Tip
            // 
            this.trackBar1Tip.IsBalloon = true;
            // 
            // trackBar2Tip
            // 
            this.trackBar2Tip.IsBalloon = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 734);
            this.Controls.Add(this.ButtonTrim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSwap);
            this.Controls.Add(this.ButtonTransferLeft);
            this.Controls.Add(this.ButtonTransferRight);
            this.Controls.Add(this.ButtonTransferRightRight);
            this.Controls.Add(this.ButtonTransferLeftLeft);
            this.Controls.Add(this.ButtonTransfer);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.textBoxNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrom";
            this.Text = "Putransfer";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Stack TextStkOld;
        private Stack TextStkNew;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.Button ButtonTransfer;
        private System.Windows.Forms.Button ButtonTransferLeftLeft;
        private System.Windows.Forms.Button ButtonTransferRightRight;
        private System.Windows.Forms.Button ButtonTransferRight;
        private System.Windows.Forms.Button ButtonTransferLeft;
        private System.Windows.Forms.Button ButtonSwap;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ButtonBackTip;
        private System.Windows.Forms.Button ButtonTrim;
        private System.Windows.Forms.ToolTip ButtonSwapTip;
        private System.Windows.Forms.ToolTip ButtonTrimTip;
        private System.Windows.Forms.ToolTip ButtonTransferTip;
        private System.Windows.Forms.ToolTip ButtonLeftTip;
        private System.Windows.Forms.ToolTip ButtonLeftLeftTip;
        private System.Windows.Forms.ToolTip ButtonRightTip;
        private System.Windows.Forms.ToolTip ButtonRightRightTip;
        private System.Windows.Forms.ToolTip trackBar1Tip;
        private System.Windows.Forms.ToolTip trackBar2Tip;
    }
}

