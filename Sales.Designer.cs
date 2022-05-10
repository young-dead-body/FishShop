
using System;
using System.Windows.Forms;

namespace FishShop
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПартнераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПартнераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюОПартнереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взаимодействиеСПокупателямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПокупателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюОПокупателеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоПродажеТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоНаличиюТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.просмотрПоступленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(4, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 196);
            this.panel3.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 160);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 33);
            this.button7.TabIndex = 6;
            this.button7.Text = "Купить всё";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Удалить товар";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(331, 150);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(644, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 52);
            this.button4.TabIndex = 2;
            this.button4.Text = "Покупатели";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 52);
            this.button3.TabIndex = 1;
            this.button3.Text = "Партнеры";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "За покупками";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem,
            this.добавитьПаToolStripMenuItem,
            this.взаимодействиеСПокупателямиToolStripMenuItem,
            this.просмотрПоступленийToolStripMenuItem,
            this.учетПродажToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem1,
            this.удалитьТоварToolStripMenuItem,
            this.изменитьТоварToolStripMenuItem});
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.добавитьТоварToolStripMenuItem.Text = "Взаимодействие с товарами";
            // 
            // добавитьТоварToolStripMenuItem1
            // 
            this.добавитьТоварToolStripMenuItem1.Name = "добавитьТоварToolStripMenuItem1";
            this.добавитьТоварToolStripMenuItem1.Size = new System.Drawing.Size(325, 26);
            this.добавитьТоварToolStripMenuItem1.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem1.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem1_Click);
            // 
            // удалитьТоварToolStripMenuItem
            // 
            this.удалитьТоварToolStripMenuItem.Name = "удалитьТоварToolStripMenuItem";
            this.удалитьТоварToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.удалитьТоварToolStripMenuItem.Text = "Удалить товар";
            this.удалитьТоварToolStripMenuItem.Click += new System.EventHandler(this.удалитьТоварToolStripMenuItem_Click);
            // 
            // изменитьТоварToolStripMenuItem
            // 
            this.изменитьТоварToolStripMenuItem.Name = "изменитьТоварToolStripMenuItem";
            this.изменитьТоварToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.изменитьТоварToolStripMenuItem.Text = "Изменить информацию о товаре";
            this.изменитьТоварToolStripMenuItem.Click += new System.EventHandler(this.изменитьТоварToolStripMenuItem_Click);
            // 
            // добавитьПаToolStripMenuItem
            // 
            this.добавитьПаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПартнераToolStripMenuItem,
            this.удалитьПартнераToolStripMenuItem,
            this.изменитьИнформациюОПартнереToolStripMenuItem});
            this.добавитьПаToolStripMenuItem.Name = "добавитьПаToolStripMenuItem";
            this.добавитьПаToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.добавитьПаToolStripMenuItem.Text = "Взаимодействие с партнерами";
            // 
            // добавитьПартнераToolStripMenuItem
            // 
            this.добавитьПартнераToolStripMenuItem.Name = "добавитьПартнераToolStripMenuItem";
            this.добавитьПартнераToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.добавитьПартнераToolStripMenuItem.Text = "Добавить партнера";
            this.добавитьПартнераToolStripMenuItem.Click += new System.EventHandler(this.добавитьПартнераToolStripMenuItem_Click);
            // 
            // удалитьПартнераToolStripMenuItem
            // 
            this.удалитьПартнераToolStripMenuItem.Name = "удалитьПартнераToolStripMenuItem";
            this.удалитьПартнераToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.удалитьПартнераToolStripMenuItem.Text = "Удалить партнера";
            this.удалитьПартнераToolStripMenuItem.Click += new System.EventHandler(this.удалитьПартнераToolStripMenuItem_Click);
            // 
            // изменитьИнформациюОПартнереToolStripMenuItem
            // 
            this.изменитьИнформациюОПартнереToolStripMenuItem.Name = "изменитьИнформациюОПартнереToolStripMenuItem";
            this.изменитьИнформациюОПартнереToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.изменитьИнформациюОПартнереToolStripMenuItem.Text = "Изменить информацию о партнере";
            this.изменитьИнформациюОПартнереToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюОПартнереToolStripMenuItem_Click);
            // 
            // взаимодействиеСПокупателямиToolStripMenuItem
            // 
            this.взаимодействиеСПокупателямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПокупателяToolStripMenuItem,
            this.изменитьИнформациюОПокупателеToolStripMenuItem});
            this.взаимодействиеСПокупателямиToolStripMenuItem.Name = "взаимодействиеСПокупателямиToolStripMenuItem";
            this.взаимодействиеСПокупателямиToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.взаимодействиеСПокупателямиToolStripMenuItem.Text = "Взаимодействие с покупателями";
            // 
            // добавитьПокупателяToolStripMenuItem
            // 
            this.добавитьПокупателяToolStripMenuItem.Name = "добавитьПокупателяToolStripMenuItem";
            this.добавитьПокупателяToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.добавитьПокупателяToolStripMenuItem.Text = "Добавить покупателя";
            this.добавитьПокупателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПокупателяToolStripMenuItem_Click);
            // 
            // изменитьИнформациюОПокупателеToolStripMenuItem
            // 
            this.изменитьИнформациюОПокупателеToolStripMenuItem.Name = "изменитьИнформациюОПокупателеToolStripMenuItem";
            this.изменитьИнформациюОПокупателеToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.изменитьИнформациюОПокупателеToolStripMenuItem.Text = "Изменить информацию о покупателе";
            this.изменитьИнформациюОПокупателеToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюОПокупателеToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетToolStripMenuItem,
            this.отчетПоПродажеТоваровToolStripMenuItem,
            this.отчетПоНаличиюТоваровToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.отчетToolStripMenuItem.Text = "Отчет по поступлению товаров";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // отчетПоПродажеТоваровToolStripMenuItem
            // 
            this.отчетПоПродажеТоваровToolStripMenuItem.Name = "отчетПоПродажеТоваровToolStripMenuItem";
            this.отчетПоПродажеТоваровToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.отчетПоПродажеТоваровToolStripMenuItem.Text = "Отчет по продаже товаров";
            this.отчетПоПродажеТоваровToolStripMenuItem.Click += new System.EventHandler(this.отчетПоПродажеТоваровToolStripMenuItem_Click);
            // 
            // отчетПоНаличиюТоваровToolStripMenuItem
            // 
            this.отчетПоНаличиюТоваровToolStripMenuItem.Name = "отчетПоНаличиюТоваровToolStripMenuItem";
            this.отчетПоНаличиюТоваровToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.отчетПоНаличиюТоваровToolStripMenuItem.Text = "Отчет по наличию товаров";
            this.отчетПоНаличиюТоваровToolStripMenuItem.Click += new System.EventHandler(this.отчетПоНаличиюТоваровToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 422);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Location = new System.Drawing.Point(568, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 110);
            this.panel5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "<наименование товара>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(87, 54);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 38);
            this.button8.TabIndex = 0;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(569, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 230);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(97, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "Приобрести";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = " вы хотели бы его приобрести?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "в каком количестве";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "<наименование товара>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы выбрали товар";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Зимняя рыбалка",
            "Удилища",
            "Катушки",
            "Лески и плетеные шнуры",
            "Крючки",
            "Джиг-головки",
            "Поплавки",
            "Оснастка",
            "Приманки",
            "Прикормка",
            "Аксессуары рыболовные",
            "Хранение и транспортировка",
            "Одежда и аксессуары",
            "Обувь",
            "Лодки и моторы"});
            this.comboBox2.Location = new System.Drawing.Point(568, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // просмотрПоступленийToolStripMenuItem
            // 
            this.просмотрПоступленийToolStripMenuItem.Name = "просмотрПоступленийToolStripMenuItem";
            this.просмотрПоступленийToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.просмотрПоступленийToolStripMenuItem.Text = "Просмотр поступлений";
            this.просмотрПоступленийToolStripMenuItem.Click += new System.EventHandler(this.просмотрПоступленийToolStripMenuItem_Click);
            // 
            // учетПродажToolStripMenuItem
            // 
            this.учетПродажToolStripMenuItem.Name = "учетПродажToolStripMenuItem";
            this.учетПродажToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.учетПродажToolStripMenuItem.Text = "Учет продаж";
            this.учетПродажToolStripMenuItem.Click += new System.EventHandler(this.учетПродажToolStripMenuItem_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales";
            this.Text = "Страница продавца";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Panel panel3;
        private Button button5;
        private DataGridView dataGridView2;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button6;
        private Button button7;
        private ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private ToolStripMenuItem добавитьТоварToolStripMenuItem1;
        private ToolStripMenuItem удалитьТоварToolStripMenuItem;
        private ToolStripMenuItem добавитьПаToolStripMenuItem;
        private ToolStripMenuItem взаимодействиеСПокупателямиToolStripMenuItem;
        private ToolStripMenuItem изменитьТоварToolStripMenuItem;
        private ToolStripMenuItem добавитьПартнераToolStripMenuItem;
        private ToolStripMenuItem удалитьПартнераToolStripMenuItem;
        private ToolStripMenuItem изменитьИнформациюОПартнереToolStripMenuItem;
        private ToolStripMenuItem добавитьПокупателяToolStripMenuItem;
        private ToolStripMenuItem изменитьИнформациюОПокупателеToolStripMenuItem;
        private Panel panel5;
        private Button button8;
        private Label label6;
        private Label label5;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem отчетПоПродажеТоваровToolStripMenuItem;
        private ToolStripMenuItem отчетПоНаличиюТоваровToolStripMenuItem;
        private ComboBox comboBox2;
        private ToolStripMenuItem просмотрПоступленийToolStripMenuItem;
        private ToolStripMenuItem учетПродажToolStripMenuItem;
    }
}