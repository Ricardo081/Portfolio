
namespace Lone_Star_Airlines
{
    partial class Register
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.sliderBaggageWeight = new System.Windows.Forms.NumericUpDown();
            this.calSelectDates = new System.Windows.Forms.MonthCalendar();
            this.dtpPassExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPassIssueDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnIdCard = new System.Windows.Forms.RadioButton();
            this.rbtnPassport = new System.Windows.Forms.RadioButton();
            this.txtbxDocNo = new System.Windows.Forms.TextBox();
            this.txtbxlName = new System.Windows.Forms.TextBox();
            this.txtbxfName = new System.Windows.Forms.TextBox();
            this.txtbxFrom = new System.Windows.Forms.TextBox();
            this.txtbxTo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDocExpDate = new System.Windows.Forms.Label();
            this.lbDocIssuDate = new System.Windows.Forms.Label();
            this.lbDocumentNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBaggageWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSubmit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(-1, 700);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(1269, 35);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(535, 623);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 23);
            this.label11.TabIndex = 67;
            this.label11.Text = "lbs";
            // 
            // sliderBaggageWeight
            // 
            this.sliderBaggageWeight.Location = new System.Drawing.Point(472, 625);
            this.sliderBaggageWeight.Name = "sliderBaggageWeight";
            this.sliderBaggageWeight.Size = new System.Drawing.Size(54, 20);
            this.sliderBaggageWeight.TabIndex = 66;
            // 
            // calSelectDates
            // 
            this.calSelectDates.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calSelectDates.Location = new System.Drawing.Point(68, 119);
            this.calSelectDates.Name = "calSelectDates";
            this.calSelectDates.TabIndex = 65;
            // 
            // dtpPassExpiryDate
            // 
            this.dtpPassExpiryDate.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPassExpiryDate.Location = new System.Drawing.Point(941, 526);
            this.dtpPassExpiryDate.Name = "dtpPassExpiryDate";
            this.dtpPassExpiryDate.Size = new System.Drawing.Size(287, 24);
            this.dtpPassExpiryDate.TabIndex = 64;
            // 
            // dtpPassIssueDate
            // 
            this.dtpPassIssueDate.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPassIssueDate.Location = new System.Drawing.Point(342, 528);
            this.dtpPassIssueDate.Name = "dtpPassIssueDate";
            this.dtpPassIssueDate.Size = new System.Drawing.Size(287, 24);
            this.dtpPassIssueDate.TabIndex = 63;
            this.dtpPassIssueDate.ValueChanged += new System.EventHandler(this.dtpPassIssueDate_ValueChanged);
            // 
            // rbtnIdCard
            // 
            this.rbtnIdCard.AutoSize = true;
            this.rbtnIdCard.BackColor = System.Drawing.Color.Transparent;
            this.rbtnIdCard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIdCard.Location = new System.Drawing.Point(402, 434);
            this.rbtnIdCard.Name = "rbtnIdCard";
            this.rbtnIdCard.Size = new System.Drawing.Size(216, 22);
            this.rbtnIdCard.TabIndex = 62;
            this.rbtnIdCard.TabStop = true;
            this.rbtnIdCard.Text = "Identification Card";
            this.rbtnIdCard.UseVisualStyleBackColor = false;
            this.rbtnIdCard.CheckedChanged += new System.EventHandler(this.rbtnIdCard_CheckedChanged);
            // 
            // rbtnPassport
            // 
            this.rbtnPassport.AutoSize = true;
            this.rbtnPassport.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPassport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPassport.Location = new System.Drawing.Point(290, 434);
            this.rbtnPassport.Name = "rbtnPassport";
            this.rbtnPassport.Size = new System.Drawing.Size(106, 22);
            this.rbtnPassport.TabIndex = 61;
            this.rbtnPassport.TabStop = true;
            this.rbtnPassport.Text = "Passport";
            this.rbtnPassport.UseVisualStyleBackColor = false;
            this.rbtnPassport.CheckedChanged += new System.EventHandler(this.rbtnPassport_CheckedChanged);
            // 
            // txtbxDocNo
            // 
            this.txtbxDocNo.Location = new System.Drawing.Point(807, 432);
            this.txtbxDocNo.Name = "txtbxDocNo";
            this.txtbxDocNo.Size = new System.Drawing.Size(214, 20);
            this.txtbxDocNo.TabIndex = 60;
            // 
            // txtbxlName
            // 
            this.txtbxlName.Location = new System.Drawing.Point(621, 330);
            this.txtbxlName.Name = "txtbxlName";
            this.txtbxlName.Size = new System.Drawing.Size(214, 20);
            this.txtbxlName.TabIndex = 59;
            // 
            // txtbxfName
            // 
            this.txtbxfName.Location = new System.Drawing.Point(224, 327);
            this.txtbxfName.Name = "txtbxfName";
            this.txtbxfName.Size = new System.Drawing.Size(214, 20);
            this.txtbxfName.TabIndex = 58;
            // 
            // txtbxFrom
            // 
            this.txtbxFrom.Location = new System.Drawing.Point(437, 10);
            this.txtbxFrom.Name = "txtbxFrom";
            this.txtbxFrom.Size = new System.Drawing.Size(214, 20);
            this.txtbxFrom.TabIndex = 57;
            // 
            // txtbxTo
            // 
            this.txtbxTo.Location = new System.Drawing.Point(121, 9);
            this.txtbxTo.Name = "txtbxTo";
            this.txtbxTo.Size = new System.Drawing.Size(214, 20);
            this.txtbxTo.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 623);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 23);
            this.label10.TabIndex = 55;
            this.label10.Text = "Baggage (provide an estimate):";
            // 
            // lbDocExpDate
            // 
            this.lbDocExpDate.AutoSize = true;
            this.lbDocExpDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDocExpDate.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocExpDate.Location = new System.Drawing.Point(652, 528);
            this.lbDocExpDate.Name = "lbDocExpDate";
            this.lbDocExpDate.Size = new System.Drawing.Size(283, 23);
            this.lbDocExpDate.TabIndex = 54;
            this.lbDocExpDate.Text = "Document Expiry Date:";
            // 
            // lbDocIssuDate
            // 
            this.lbDocIssuDate.AutoSize = true;
            this.lbDocIssuDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDocIssuDate.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocIssuDate.Location = new System.Drawing.Point(65, 526);
            this.lbDocIssuDate.Name = "lbDocIssuDate";
            this.lbDocIssuDate.Size = new System.Drawing.Size(270, 23);
            this.lbDocIssuDate.TabIndex = 53;
            this.lbDocIssuDate.Text = "Document Issue Date:";
            // 
            // lbDocumentNum
            // 
            this.lbDocumentNum.AutoSize = true;
            this.lbDocumentNum.BackColor = System.Drawing.Color.Transparent;
            this.lbDocumentNum.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocumentNum.Location = new System.Drawing.Point(635, 432);
            this.lbDocumentNum.Name = "lbDocumentNum";
            this.lbDocumentNum.Size = new System.Drawing.Size(166, 23);
            this.lbDocumentNum.TabIndex = 52;
            this.lbDocumentNum.Text = "Document No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Travel Document:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(628, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Choose your schedule (Scroll to select range or use Shift Key)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "To:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lone_Star_Airlines.Properties.Resources._0ff44cea_5d7c_4e25_bd0c_f6d25d706f72_shutterstock_553131187;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 735);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sliderBaggageWeight);
            this.Controls.Add(this.calSelectDates);
            this.Controls.Add(this.dtpPassExpiryDate);
            this.Controls.Add(this.dtpPassIssueDate);
            this.Controls.Add(this.rbtnIdCard);
            this.Controls.Add(this.rbtnPassport);
            this.Controls.Add(this.txtbxDocNo);
            this.Controls.Add(this.txtbxlName);
            this.Controls.Add(this.txtbxfName);
            this.Controls.Add(this.txtbxFrom);
            this.Controls.Add(this.txtbxTo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbDocExpDate);
            this.Controls.Add(this.lbDocIssuDate);
            this.Controls.Add(this.lbDocumentNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderBaggageWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown sliderBaggageWeight;
        private System.Windows.Forms.MonthCalendar calSelectDates;
        private System.Windows.Forms.DateTimePicker dtpPassExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpPassIssueDate;
        private System.Windows.Forms.RadioButton rbtnIdCard;
        private System.Windows.Forms.RadioButton rbtnPassport;
        private System.Windows.Forms.TextBox txtbxDocNo;
        private System.Windows.Forms.TextBox txtbxlName;
        private System.Windows.Forms.TextBox txtbxfName;
        private System.Windows.Forms.TextBox txtbxFrom;
        private System.Windows.Forms.TextBox txtbxTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDocExpDate;
        private System.Windows.Forms.Label lbDocIssuDate;
        private System.Windows.Forms.Label lbDocumentNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

