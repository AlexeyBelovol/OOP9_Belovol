namespace Lab9
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            labelA = new Label();
            labelB = new Label();
            buttonPlot = new Button();
            pictureBoxGraph = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).BeginInit();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(23, 69);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(181, 69);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 1;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(23, 35);
            labelA.Name = "labelA";
            labelA.Size = new Size(100, 15);
            labelA.TabIndex = 2;
            labelA.Text = "Введіть змінну A:";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(182, 35);
            labelB.Name = "labelB";
            labelB.Size = new Size(99, 15);
            labelB.TabIndex = 3;
            labelB.Text = "Введіть змінну B:";
            // 
            // buttonPlot
            // 
            buttonPlot.Location = new Point(65, 198);
            buttonPlot.Name = "buttonPlot";
            buttonPlot.Size = new Size(194, 103);
            buttonPlot.TabIndex = 4;
            buttonPlot.Text = "Накреслити";
            buttonPlot.UseVisualStyleBackColor = true;
            buttonPlot.Click += buttonPlot_Click;
            // 
            // pictureBoxGraph
            // 
            pictureBoxGraph.Location = new Point(331, 27);
            pictureBoxGraph.Name = "pictureBoxGraph";
            pictureBoxGraph.Size = new Size(444, 411);
            pictureBoxGraph.TabIndex = 5;
            pictureBoxGraph.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxGraph);
            Controls.Add(buttonPlot);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private Label labelA;
        private Label labelB;
        private Button buttonPlot;
        private PictureBox pictureBoxGraph;
    }
}
