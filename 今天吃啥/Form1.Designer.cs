
namespace 今天吃啥
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataFrom = new System.Windows.Forms.Label();
            this.openData = new System.Windows.Forms.Button();
            this.priceFilter = new System.Windows.Forms.CheckBox();
            this.priceIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runIt = new System.Windows.Forms.Button();
            this.UselessText1 = new System.Windows.Forms.Label();
            this.UselessText2 = new System.Windows.Forms.Label();
            this.UselessText3 = new System.Windows.Forms.Label();
            this.UselessText4 = new System.Windows.Forms.Label();
            this.FirstRestaurant = new System.Windows.Forms.Label();
            this.SecondRestaurant = new System.Windows.Forms.Label();
            this.ThirdRestaurant = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFrom
            // 
            resources.ApplyResources(this.dataFrom, "dataFrom");
            this.dataFrom.Name = "dataFrom";
            this.dataFrom.Click += new System.EventHandler(this.dataFrom_Click);
            // 
            // openData
            // 
            resources.ApplyResources(this.openData, "openData");
            this.openData.Name = "openData";
            this.openData.UseVisualStyleBackColor = true;
            this.openData.Click += new System.EventHandler(this.openData_Click);
            // 
            // priceFilter
            // 
            resources.ApplyResources(this.priceFilter, "priceFilter");
            this.priceFilter.BackColor = System.Drawing.SystemColors.Window;
            this.priceFilter.Name = "priceFilter";
            this.priceFilter.UseVisualStyleBackColor = false;
            this.priceFilter.CheckedChanged += new System.EventHandler(this.priceFilter_CheckedChanged);
            // 
            // priceIn
            // 
            resources.ApplyResources(this.priceIn, "priceIn");
            this.priceIn.Name = "priceIn";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // runIt
            // 
            this.runIt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runIt.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.runIt, "runIt");
            this.runIt.Name = "runIt";
            this.runIt.UseVisualStyleBackColor = false;
            this.runIt.Click += new System.EventHandler(this.runIt_Click);
            // 
            // UselessText1
            // 
            resources.ApplyResources(this.UselessText1, "UselessText1");
            this.UselessText1.Name = "UselessText1";
            // 
            // UselessText2
            // 
            resources.ApplyResources(this.UselessText2, "UselessText2");
            this.UselessText2.Name = "UselessText2";
            // 
            // UselessText3
            // 
            resources.ApplyResources(this.UselessText3, "UselessText3");
            this.UselessText3.Name = "UselessText3";
            // 
            // UselessText4
            // 
            resources.ApplyResources(this.UselessText4, "UselessText4");
            this.UselessText4.Name = "UselessText4";
            // 
            // FirstRestaurant
            // 
            resources.ApplyResources(this.FirstRestaurant, "FirstRestaurant");
            this.FirstRestaurant.Name = "FirstRestaurant";
            // 
            // SecondRestaurant
            // 
            resources.ApplyResources(this.SecondRestaurant, "SecondRestaurant");
            this.SecondRestaurant.Name = "SecondRestaurant";
            // 
            // ThirdRestaurant
            // 
            resources.ApplyResources(this.ThirdRestaurant, "ThirdRestaurant");
            this.ThirdRestaurant.Name = "ThirdRestaurant";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ThirdRestaurant);
            this.Controls.Add(this.SecondRestaurant);
            this.Controls.Add(this.FirstRestaurant);
            this.Controls.Add(this.UselessText4);
            this.Controls.Add(this.UselessText3);
            this.Controls.Add(this.UselessText2);
            this.Controls.Add(this.UselessText1);
            this.Controls.Add(this.runIt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceIn);
            this.Controls.Add(this.priceFilter);
            this.Controls.Add(this.openData);
            this.Controls.Add(this.dataFrom);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataFrom;
        private System.Windows.Forms.Button openData;
        private System.Windows.Forms.CheckBox priceFilter;
        private System.Windows.Forms.TextBox priceIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runIt;
        private System.Windows.Forms.Label UselessText1;
        private System.Windows.Forms.Label UselessText2;
        private System.Windows.Forms.Label UselessText3;
        private System.Windows.Forms.Label UselessText4;
        private System.Windows.Forms.Label FirstRestaurant;
        private System.Windows.Forms.Label SecondRestaurant;
        private System.Windows.Forms.Label ThirdRestaurant;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

