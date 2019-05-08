namespace Final_Project
{
    partial class FinalForm
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
            this.txtdFirst = new System.Windows.Forms.TextBox();
            this.txtdLast = new System.Windows.Forms.TextBox();
            this.lbldLast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdAddress = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdZip = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtmFirst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmLast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmAddress = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmZip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmTelephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdFirst
            // 
            this.txtdFirst.Location = new System.Drawing.Point(12, 62);
            this.txtdFirst.Name = "txtdFirst";
            this.txtdFirst.Size = new System.Drawing.Size(85, 20);
            this.txtdFirst.TabIndex = 0;
            // 
            // txtdLast
            // 
            this.txtdLast.Location = new System.Drawing.Point(114, 62);
            this.txtdLast.Name = "txtdLast";
            this.txtdLast.Size = new System.Drawing.Size(132, 20);
            this.txtdLast.TabIndex = 1;
            // 
            // lbldLast
            // 
            this.lbldLast.AutoSize = true;
            this.lbldLast.Location = new System.Drawing.Point(117, 46);
            this.lbldLast.Name = "lbldLast";
            this.lbldLast.Size = new System.Drawing.Size(27, 13);
            this.lbldLast.TabIndex = 2;
            this.lbldLast.Text = "Last";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // txtdAddress
            // 
            this.txtdAddress.Location = new System.Drawing.Point(15, 105);
            this.txtdAddress.Name = "txtdAddress";
            this.txtdAddress.Size = new System.Drawing.Size(231, 20);
            this.txtdAddress.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(269, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(269, 89);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 8;
            this.Amount.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // txtdState
            // 
            this.txtdState.Location = new System.Drawing.Point(15, 155);
            this.txtdState.Name = "txtdState";
            this.txtdState.Size = new System.Drawing.Size(129, 20);
            this.txtdState.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "State";
            // 
            // txtdZip
            // 
            this.txtdZip.Location = new System.Drawing.Point(170, 155);
            this.txtdZip.Name = "txtdZip";
            this.txtdZip.Size = new System.Drawing.Size(88, 20);
            this.txtdZip.TabIndex = 12;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Location = new System.Drawing.Point(167, 139);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(22, 13);
            this.Zip.TabIndex = 13;
            this.Zip.Text = "Zip";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(49, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(120, 193);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 29);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(252, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(49, 250);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(678, 150);
            this.dgvData.TabIndex = 18;
            // 
            // txtmFirst
            // 
            this.txtmFirst.Location = new System.Drawing.Point(436, 62);
            this.txtmFirst.Name = "txtmFirst";
            this.txtmFirst.Size = new System.Drawing.Size(78, 20);
            this.txtmFirst.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "First";
            // 
            // txtmLast
            // 
            this.txtmLast.Location = new System.Drawing.Point(520, 62);
            this.txtmLast.Name = "txtmLast";
            this.txtmLast.Size = new System.Drawing.Size(116, 20);
            this.txtmLast.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Last";
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(695, 62);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(69, 20);
            this.txtGoal.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Goal";
            // 
            // txtmAddress
            // 
            this.txtmAddress.Location = new System.Drawing.Point(436, 105);
            this.txtmAddress.Name = "txtmAddress";
            this.txtmAddress.Size = new System.Drawing.Size(187, 20);
            this.txtmAddress.TabIndex = 25;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(698, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(66, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total";
            // 
            // txtmState
            // 
            this.txtmState.Location = new System.Drawing.Point(436, 155);
            this.txtmState.Name = "txtmState";
            this.txtmState.Size = new System.Drawing.Size(100, 20);
            this.txtmState.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "State";
            // 
            // txtmZip
            // 
            this.txtmZip.Location = new System.Drawing.Point(556, 155);
            this.txtmZip.Name = "txtmZip";
            this.txtmZip.Size = new System.Drawing.Size(67, 20);
            this.txtmZip.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Zip";
            // 
            // txtmTelephone
            // 
            this.txtmTelephone.Location = new System.Drawing.Point(436, 202);
            this.txtmTelephone.Name = "txtmTelephone";
            this.txtmTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtmTelephone.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Telephone";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(698, 202);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 23);
            this.btnOpen.TabIndex = 35;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtmTelephone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmZip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtmState);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtmAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmLast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmFirst);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.txtdZip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtdAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldLast);
            this.Controls.Add(this.txtdLast);
            this.Controls.Add(this.txtdFirst);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdFirst;
        private System.Windows.Forms.TextBox txtdLast;
        private System.Windows.Forms.Label lbldLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdAddress;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdZip;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtmFirst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmAddress;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmZip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmTelephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

