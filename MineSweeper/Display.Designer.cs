namespace MineSweeper
{
    partial class Display
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelBlocks = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMines = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.textCols = new System.Windows.Forms.TextBox();
            this.labelCols_ = new System.Windows.Forms.Label();
            this.textRows = new System.Windows.Forms.TextBox();
            this.labelrows_ = new System.Windows.Forms.Label();
            this.textMines = new System.Windows.Forms.TextBox();
            this.labelmine_ = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBlocks
            // 
            this.PanelBlocks.AutoSize = true;
            this.PanelBlocks.Location = new System.Drawing.Point(107, 225);
            this.PanelBlocks.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBlocks.Name = "PanelBlocks";
            this.PanelBlocks.Size = new System.Drawing.Size(482, 420);
            this.PanelBlocks.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStart.Location = new System.Drawing.Point(243, 81);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 50);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelMines
            // 
            this.labelMines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMines.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMines.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMines.ForeColor = System.Drawing.Color.Red;
            this.labelMines.Location = new System.Drawing.Point(79, 81);
            this.labelMines.Name = "labelMines";
            this.labelMines.Size = new System.Drawing.Size(100, 50);
            this.labelMines.TabIndex = 2;
            this.labelMines.Text = "0";
            this.labelMines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTime.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(449, 81);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 50);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "0";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCols
            // 
            this.textCols.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCols.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textCols.Location = new System.Drawing.Point(74, 15);
            this.textCols.Name = "textCols";
            this.textCols.Size = new System.Drawing.Size(101, 34);
            this.textCols.TabIndex = 1;
            // 
            // labelCols_
            // 
            this.labelCols_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCols_.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCols_.Location = new System.Drawing.Point(9, 15);
            this.labelCols_.Name = "labelCols_";
            this.labelCols_.Size = new System.Drawing.Size(59, 34);
            this.labelCols_.TabIndex = 4;
            this.labelCols_.Text = "行數";
            this.labelCols_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textRows
            // 
            this.textRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRows.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textRows.Location = new System.Drawing.Point(268, 17);
            this.textRows.Name = "textRows";
            this.textRows.Size = new System.Drawing.Size(101, 34);
            this.textRows.TabIndex = 2;
            // 
            // labelrows_
            // 
            this.labelrows_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelrows_.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelrows_.Location = new System.Drawing.Point(203, 17);
            this.labelrows_.Name = "labelrows_";
            this.labelrows_.Size = new System.Drawing.Size(59, 34);
            this.labelrows_.TabIndex = 4;
            this.labelrows_.Text = "列數";
            this.labelrows_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMines
            // 
            this.textMines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMines.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textMines.Location = new System.Drawing.Point(486, 19);
            this.textMines.Name = "textMines";
            this.textMines.Size = new System.Drawing.Size(101, 34);
            this.textMines.TabIndex = 3;
            // 
            // labelmine_
            // 
            this.labelmine_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelmine_.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelmine_.Location = new System.Drawing.Point(398, 17);
            this.labelmine_.Name = "labelmine_";
            this.labelmine_.Size = new System.Drawing.Size(82, 34);
            this.labelmine_.TabIndex = 6;
            this.labelmine_.Text = "地雷數";
            this.labelmine_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelmine_);
            this.panelInfo.Controls.Add(this.textMines);
            this.panelInfo.Controls.Add(this.labelrows_);
            this.panelInfo.Controls.Add(this.labelCols_);
            this.panelInfo.Controls.Add(this.textRows);
            this.panelInfo.Controls.Add(this.textCols);
            this.panelInfo.Controls.Add(this.labelTime);
            this.panelInfo.Controls.Add(this.labelMines);
            this.panelInfo.Controls.Add(this.buttonStart);
            this.panelInfo.Location = new System.Drawing.Point(40, 40);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(600, 150);
            this.panelInfo.TabIndex = 7;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 546);
            this.Controls.Add(this.PanelBlocks);
            this.Controls.Add(this.panelInfo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineSweeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBlocks;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelMines;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textCols;
        private System.Windows.Forms.Label labelCols_;
        private System.Windows.Forms.TextBox textRows;
        private System.Windows.Forms.Label labelrows_;
        private System.Windows.Forms.TextBox textMines;
        private System.Windows.Forms.Label labelmine_;
        private System.Windows.Forms.Panel panelInfo;

    }
}

