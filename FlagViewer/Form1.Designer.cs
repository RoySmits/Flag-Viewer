namespace FlagViewer
{
    partial class FlagViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlagViewer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.Location = new System.Drawing.Point(597, 51);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(250, 43);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.Location = new System.Drawing.Point(3, 51);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(291, 43);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Next, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Previous, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 404);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 97);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the \'Next\' button to start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "afghanistan.gif");
            this.imageList1.Images.SetKeyName(1, "aland_islands.gif");
            this.imageList1.Images.SetKeyName(2, "albania.gif");
            this.imageList1.Images.SetKeyName(3, "algeria.gif");
            this.imageList1.Images.SetKeyName(4, "american_samoa.gif");
            this.imageList1.Images.SetKeyName(5, "andorra.gif");
            this.imageList1.Images.SetKeyName(6, "angola.gif");
            this.imageList1.Images.SetKeyName(7, "anguilla.gif");
            this.imageList1.Images.SetKeyName(8, "antarctica.gif");
            this.imageList1.Images.SetKeyName(9, "antigua_and_barbuda.gif");
            this.imageList1.Images.SetKeyName(10, "argentina.gif");
            this.imageList1.Images.SetKeyName(11, "armenia.gif");
            this.imageList1.Images.SetKeyName(12, "aruba.gif");
            this.imageList1.Images.SetKeyName(13, "australia.gif");
            this.imageList1.Images.SetKeyName(14, "austria.gif");
            this.imageList1.Images.SetKeyName(15, "azerbaijan.gif");
            this.imageList1.Images.SetKeyName(16, "bahamas.gif");
            this.imageList1.Images.SetKeyName(17, "bahrain.gif");
            this.imageList1.Images.SetKeyName(18, "bangladesh.gif");
            this.imageList1.Images.SetKeyName(19, "barbados.gif");
            this.imageList1.Images.SetKeyName(20, "belarus.gif");
            this.imageList1.Images.SetKeyName(21, "belgium.gif");
            this.imageList1.Images.SetKeyName(22, "belize.gif");
            this.imageList1.Images.SetKeyName(23, "benin.gif");
            this.imageList1.Images.SetKeyName(24, "bermuda.gif");
            this.imageList1.Images.SetKeyName(25, "bhutan.gif");
            this.imageList1.Images.SetKeyName(26, "bolivia.gif");
            this.imageList1.Images.SetKeyName(27, "bonaire.gif");
            this.imageList1.Images.SetKeyName(28, "bosnia_and_herzegovina.gif");
            this.imageList1.Images.SetKeyName(29, "botswana.gif");
            this.imageList1.Images.SetKeyName(30, "bouvet_island.gif");
            this.imageList1.Images.SetKeyName(31, "brazil.gif");
            this.imageList1.Images.SetKeyName(32, "british_indian_ocean_territory.gif");
            this.imageList1.Images.SetKeyName(33, "brunei.gif");
            this.imageList1.Images.SetKeyName(34, "bulgaria.gif");
            this.imageList1.Images.SetKeyName(35, "burkina_faso.gif");
            this.imageList1.Images.SetKeyName(36, "burundi.gif");
            this.imageList1.Images.SetKeyName(37, "cambodia.gif");
            this.imageList1.Images.SetKeyName(38, "cameroon.gif");
            this.imageList1.Images.SetKeyName(39, "canada.gif");
            this.imageList1.Images.SetKeyName(40, "cape_verde.gif");
            this.imageList1.Images.SetKeyName(41, "cayman_islands.gif");
            this.imageList1.Images.SetKeyName(42, "central_african_republic.gif");
            this.imageList1.Images.SetKeyName(43, "chad.gif");
            this.imageList1.Images.SetKeyName(44, "chile.gif");
            this.imageList1.Images.SetKeyName(45, "china.gif");
            this.imageList1.Images.SetKeyName(46, "christmas_island.gif");
            this.imageList1.Images.SetKeyName(47, "cocos_islands.gif");
            this.imageList1.Images.SetKeyName(48, "colombia.gif");
            this.imageList1.Images.SetKeyName(49, "comoros.gif");
            this.imageList1.Images.SetKeyName(50, "cook_islands.gif");
            this.imageList1.Images.SetKeyName(51, "costa_rica.gif");
            this.imageList1.Images.SetKeyName(52, "cote_d_Ivoire.gif");
            this.imageList1.Images.SetKeyName(53, "croatia.gif");
            this.imageList1.Images.SetKeyName(54, "cuba.gif");
            this.imageList1.Images.SetKeyName(55, "curacao.gif");
            this.imageList1.Images.SetKeyName(56, "cyprus.gif");
            this.imageList1.Images.SetKeyName(57, "czech_republic.gif");
            this.imageList1.Images.SetKeyName(58, "democratic_republic_of_the_congo.gif");
            this.imageList1.Images.SetKeyName(59, "denmark.gif");
            this.imageList1.Images.SetKeyName(60, "djibouti.gif");
            this.imageList1.Images.SetKeyName(61, "dominica.gif");
            this.imageList1.Images.SetKeyName(62, "dominican_republic.gif");
            this.imageList1.Images.SetKeyName(63, "east_timor.gif");
            this.imageList1.Images.SetKeyName(64, "ecuador.gif");
            this.imageList1.Images.SetKeyName(65, "egypt.gif");
            this.imageList1.Images.SetKeyName(66, "el_salvador.gif");
            this.imageList1.Images.SetKeyName(67, "england.gif");
            this.imageList1.Images.SetKeyName(68, "equatorial_guinea.gif");
            this.imageList1.Images.SetKeyName(69, "eritrea.gif");
            this.imageList1.Images.SetKeyName(70, "estonia.gif");
            this.imageList1.Images.SetKeyName(71, "ethiopia.gif");
            this.imageList1.Images.SetKeyName(72, "european_union.gif");
            this.imageList1.Images.SetKeyName(73, "falkland_islands.gif");
            this.imageList1.Images.SetKeyName(74, "faroe_islands.gif");
            this.imageList1.Images.SetKeyName(75, "fiji.gif");
            this.imageList1.Images.SetKeyName(76, "finland.gif");
            this.imageList1.Images.SetKeyName(77, "france.gif");
            this.imageList1.Images.SetKeyName(78, "french_guiana.gif");
            this.imageList1.Images.SetKeyName(79, "french_polynesia.gif");
            this.imageList1.Images.SetKeyName(80, "french_southern_territories.gif");
            this.imageList1.Images.SetKeyName(81, "gabon.gif");
            this.imageList1.Images.SetKeyName(82, "gambia.gif");
            this.imageList1.Images.SetKeyName(83, "georgia.gif");
            this.imageList1.Images.SetKeyName(84, "germany.gif");
            this.imageList1.Images.SetKeyName(85, "ghana.gif");
            this.imageList1.Images.SetKeyName(86, "gibraltar.gif");
            this.imageList1.Images.SetKeyName(87, "greece.gif");
            this.imageList1.Images.SetKeyName(88, "greenland.gif");
            this.imageList1.Images.SetKeyName(89, "grenada.gif");
            this.imageList1.Images.SetKeyName(90, "guadeloupe.gif");
            this.imageList1.Images.SetKeyName(91, "guam.gif");
            this.imageList1.Images.SetKeyName(92, "guatemala.gif");
            this.imageList1.Images.SetKeyName(93, "guernsey.gif");
            this.imageList1.Images.SetKeyName(94, "guinea.gif");
            this.imageList1.Images.SetKeyName(95, "guinea_bissau.gif");
            this.imageList1.Images.SetKeyName(96, "guyana.gif");
            this.imageList1.Images.SetKeyName(97, "haiti.gif");
            this.imageList1.Images.SetKeyName(98, "heard_island_and_mcdonald_islands.gif");
            this.imageList1.Images.SetKeyName(99, "honduras.gif");
            this.imageList1.Images.SetKeyName(100, "hong_kong.gif");
            this.imageList1.Images.SetKeyName(101, "hungary.gif");
            this.imageList1.Images.SetKeyName(102, "iceland.gif");
            this.imageList1.Images.SetKeyName(103, "india.gif");
            this.imageList1.Images.SetKeyName(104, "indonesia.gif");
            this.imageList1.Images.SetKeyName(105, "iran.gif");
            this.imageList1.Images.SetKeyName(106, "iraq.gif");
            this.imageList1.Images.SetKeyName(107, "ireland.gif");
            this.imageList1.Images.SetKeyName(108, "isle_of_man.gif");
            this.imageList1.Images.SetKeyName(109, "israel.gif");
            this.imageList1.Images.SetKeyName(110, "italy.gif");
            this.imageList1.Images.SetKeyName(111, "jamaica.gif");
            this.imageList1.Images.SetKeyName(112, "japan.gif");
            this.imageList1.Images.SetKeyName(113, "jersey.gif");
            this.imageList1.Images.SetKeyName(114, "jordan.gif");
            this.imageList1.Images.SetKeyName(115, "kazakhstan.gif");
            this.imageList1.Images.SetKeyName(116, "kenya.gif");
            this.imageList1.Images.SetKeyName(117, "kiribati.gif");
            this.imageList1.Images.SetKeyName(118, "korea_north.gif");
            this.imageList1.Images.SetKeyName(119, "korea_south.gif");
            this.imageList1.Images.SetKeyName(120, "kosovo.gif");
            this.imageList1.Images.SetKeyName(121, "kuwait.gif");
            this.imageList1.Images.SetKeyName(122, "kyrgyzstan.gif");
            this.imageList1.Images.SetKeyName(123, "laos.gif");
            this.imageList1.Images.SetKeyName(124, "latvia.gif");
            this.imageList1.Images.SetKeyName(125, "lebanon.gif");
            this.imageList1.Images.SetKeyName(126, "lesotho.gif");
            this.imageList1.Images.SetKeyName(127, "liberia.gif");
            this.imageList1.Images.SetKeyName(128, "libya.gif");
            this.imageList1.Images.SetKeyName(129, "liechtenstein.gif");
            this.imageList1.Images.SetKeyName(130, "lithuania.gif");
            this.imageList1.Images.SetKeyName(131, "luxembourg.gif");
            this.imageList1.Images.SetKeyName(132, "macao.gif");
            this.imageList1.Images.SetKeyName(133, "macedonia.gif");
            this.imageList1.Images.SetKeyName(134, "madagascar.gif");
            this.imageList1.Images.SetKeyName(135, "malawi.gif");
            this.imageList1.Images.SetKeyName(136, "malaysia.gif");
            this.imageList1.Images.SetKeyName(137, "maldives.gif");
            this.imageList1.Images.SetKeyName(138, "mali.gif");
            this.imageList1.Images.SetKeyName(139, "malta.gif");
            this.imageList1.Images.SetKeyName(140, "marshall_islands.gif");
            this.imageList1.Images.SetKeyName(141, "martinique.gif");
            this.imageList1.Images.SetKeyName(142, "mauritania.gif");
            this.imageList1.Images.SetKeyName(143, "mauritius.gif");
            this.imageList1.Images.SetKeyName(144, "mayotte.gif");
            this.imageList1.Images.SetKeyName(145, "mexico.gif");
            this.imageList1.Images.SetKeyName(146, "micronesia.gif");
            this.imageList1.Images.SetKeyName(147, "moldova.gif");
            this.imageList1.Images.SetKeyName(148, "monaco.gif");
            this.imageList1.Images.SetKeyName(149, "mongolia.gif");
            this.imageList1.Images.SetKeyName(150, "montenegro.gif");
            this.imageList1.Images.SetKeyName(151, "montserrat.gif");
            this.imageList1.Images.SetKeyName(152, "morocco.gif");
            this.imageList1.Images.SetKeyName(153, "mozambique.gif");
            this.imageList1.Images.SetKeyName(154, "myanmar.gif");
            this.imageList1.Images.SetKeyName(155, "namibia.gif");
            this.imageList1.Images.SetKeyName(156, "nauru.gif");
            this.imageList1.Images.SetKeyName(157, "nepal.gif");
            this.imageList1.Images.SetKeyName(158, "netherlands.gif");
            this.imageList1.Images.SetKeyName(159, "new_caledonia.gif");
            this.imageList1.Images.SetKeyName(160, "new_zealand.gif");
            this.imageList1.Images.SetKeyName(161, "nicaragua.gif");
            this.imageList1.Images.SetKeyName(162, "niger.gif");
            this.imageList1.Images.SetKeyName(163, "nigeria.gif");
            this.imageList1.Images.SetKeyName(164, "niue.gif");
            this.imageList1.Images.SetKeyName(165, "norfolk_island.gif");
            this.imageList1.Images.SetKeyName(166, "northern_mariana_islands.gif");
            this.imageList1.Images.SetKeyName(167, "norway.gif");
            this.imageList1.Images.SetKeyName(168, "oman.gif");
            this.imageList1.Images.SetKeyName(169, "pakistan.gif");
            this.imageList1.Images.SetKeyName(170, "palau.gif");
            this.imageList1.Images.SetKeyName(171, "palestinian_territory.gif");
            this.imageList1.Images.SetKeyName(172, "panama.gif");
            this.imageList1.Images.SetKeyName(173, "papua_new_guinea.gif");
            this.imageList1.Images.SetKeyName(174, "paraguay.gif");
            this.imageList1.Images.SetKeyName(175, "peru.gif");
            this.imageList1.Images.SetKeyName(176, "philippines.gif");
            this.imageList1.Images.SetKeyName(177, "pitcairn_islands.gif");
            this.imageList1.Images.SetKeyName(178, "poland.gif");
            this.imageList1.Images.SetKeyName(179, "portugal.gif");
            this.imageList1.Images.SetKeyName(180, "puerto_rico.gif");
            this.imageList1.Images.SetKeyName(181, "qatar.gif");
            this.imageList1.Images.SetKeyName(182, "republic_of_china.gif");
            this.imageList1.Images.SetKeyName(183, "republic_of_the_congo.gif");
            this.imageList1.Images.SetKeyName(184, "reunion.gif");
            this.imageList1.Images.SetKeyName(185, "romania.gif");
            this.imageList1.Images.SetKeyName(186, "russia.gif");
            this.imageList1.Images.SetKeyName(187, "rwanda.gif");
            this.imageList1.Images.SetKeyName(188, "saint_barthelemy.gif");
            this.imageList1.Images.SetKeyName(189, "saint_helena.gif");
            this.imageList1.Images.SetKeyName(190, "saint_kitts_and_nevis.gif");
            this.imageList1.Images.SetKeyName(191, "saint_lucia.gif");
            this.imageList1.Images.SetKeyName(192, "saint_martin.gif");
            this.imageList1.Images.SetKeyName(193, "saint_pierre_and_miquelon.gif");
            this.imageList1.Images.SetKeyName(194, "saint_vincent_and_the_grenadines.gif");
            this.imageList1.Images.SetKeyName(195, "samoa.gif");
            this.imageList1.Images.SetKeyName(196, "san_marino.gif");
            this.imageList1.Images.SetKeyName(197, "sao_tome_and_principe.gif");
            this.imageList1.Images.SetKeyName(198, "saudi_arabia.gif");
            this.imageList1.Images.SetKeyName(199, "scotland.gif");
            this.imageList1.Images.SetKeyName(200, "senegal.gif");
            this.imageList1.Images.SetKeyName(201, "serbia.gif");
            this.imageList1.Images.SetKeyName(202, "seychelles.gif");
            this.imageList1.Images.SetKeyName(203, "sierra_leone.gif");
            this.imageList1.Images.SetKeyName(204, "singapore.gif");
            this.imageList1.Images.SetKeyName(205, "sint_maarten.gif");
            this.imageList1.Images.SetKeyName(206, "slovakia.gif");
            this.imageList1.Images.SetKeyName(207, "slovenia.gif");
            this.imageList1.Images.SetKeyName(208, "solomon_islands.gif");
            this.imageList1.Images.SetKeyName(209, "somalia.gif");
            this.imageList1.Images.SetKeyName(210, "south_africa.gif");
            this.imageList1.Images.SetKeyName(211, "south_georgia_and_the_south_sandwich_islands.gif");
            this.imageList1.Images.SetKeyName(212, "south_sudan.gif");
            this.imageList1.Images.SetKeyName(213, "spain.gif");
            this.imageList1.Images.SetKeyName(214, "sri_lanka.gif");
            this.imageList1.Images.SetKeyName(215, "sudan.gif");
            this.imageList1.Images.SetKeyName(216, "suriname.gif");
            this.imageList1.Images.SetKeyName(217, "svalbard_and_jan_mayen.gif");
            this.imageList1.Images.SetKeyName(218, "swaziland.gif");
            this.imageList1.Images.SetKeyName(219, "sweden.gif");
            this.imageList1.Images.SetKeyName(220, "switzerland.gif");
            this.imageList1.Images.SetKeyName(221, "syria.gif");
            this.imageList1.Images.SetKeyName(222, "tajikistan.gif");
            this.imageList1.Images.SetKeyName(223, "tanzania.gif");
            this.imageList1.Images.SetKeyName(224, "thailand.gif");
            this.imageList1.Images.SetKeyName(225, "togo.gif");
            this.imageList1.Images.SetKeyName(226, "tokelau.gif");
            this.imageList1.Images.SetKeyName(227, "tonga.gif");
            this.imageList1.Images.SetKeyName(228, "trinidad_and_tobago.gif");
            this.imageList1.Images.SetKeyName(229, "tunisia.gif");
            this.imageList1.Images.SetKeyName(230, "turkey.gif");
            this.imageList1.Images.SetKeyName(231, "turkmenistan.gif");
            this.imageList1.Images.SetKeyName(232, "turks_and_caicos_islands.gif");
            this.imageList1.Images.SetKeyName(233, "tuvalu.gif");
            this.imageList1.Images.SetKeyName(234, "uganda.gif");
            this.imageList1.Images.SetKeyName(235, "ukraine.gif");
            this.imageList1.Images.SetKeyName(236, "united_arab_emirates.gif");
            this.imageList1.Images.SetKeyName(237, "united_kingdom.gif");
            this.imageList1.Images.SetKeyName(238, "united_states_of_america.gif");
            this.imageList1.Images.SetKeyName(239, "uruguay.gif");
            this.imageList1.Images.SetKeyName(240, "ussr.gif");
            this.imageList1.Images.SetKeyName(241, "uzbekistan.gif");
            this.imageList1.Images.SetKeyName(242, "vanuatu.gif");
            this.imageList1.Images.SetKeyName(243, "vatican_city.gif");
            this.imageList1.Images.SetKeyName(244, "venezuela.gif");
            this.imageList1.Images.SetKeyName(245, "vietnam.gif");
            this.imageList1.Images.SetKeyName(246, "virgin_islands_british.gif");
            this.imageList1.Images.SetKeyName(247, "virgin_islands_us.gif");
            this.imageList1.Images.SetKeyName(248, "wales.gif");
            this.imageList1.Images.SetKeyName(249, "wallis_and_futuna.gif");
            this.imageList1.Images.SetKeyName(250, "western_sahara.gif");
            this.imageList1.Images.SetKeyName(251, "yemen.gif");
            this.imageList1.Images.SetKeyName(252, "zambia.gif");
            this.imageList1.Images.SetKeyName(253, "zimbabwe.gif");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "afghanistan",
            "aland_islands",
            "albania",
            "algeria",
            "american_samoa",
            "andorra",
            "angola",
            "anguilla",
            "antarctica",
            "antigua_and_barbuda",
            "argentina",
            "armenia",
            "aruba",
            "australia",
            "austria",
            "azerbaijan",
            "bahamas",
            "bahrain",
            "bangladesh",
            "barbados",
            "belarus",
            "belgium",
            "belize",
            "benin",
            "bermuda",
            "bhutan",
            "bolivia",
            "bonaire",
            "bosnia_and_herzegovina",
            "botswana",
            "bouvet_island",
            "brazil",
            "british_indian_ocean_territory",
            "brunei",
            "bulgaria",
            "burkina_faso",
            "burundi",
            "cambodia",
            "cameroon",
            "canada",
            "cape_verde",
            "cayman_islands",
            "central_african_republic",
            "chad",
            "chile",
            "china",
            "christmas_island",
            "cocos_islands",
            "colombia",
            "comoros",
            "cook_islands",
            "costa_rica",
            "cote_d_Ivoire",
            "croatia",
            "cuba",
            "curacao",
            "cyprus",
            "czech_republic",
            "democratic_republic_of_the_congo",
            "denmark",
            "djibouti",
            "dominica",
            "dominican_republic",
            "east_timor",
            "ecuador",
            "egypt",
            "el_salvador",
            "england",
            "equatorial_guinea",
            "eritrea",
            "estonia",
            "ethiopia",
            "european_union",
            "falkland_islands",
            "faroe_islands",
            "fiji",
            "finland",
            "france",
            "french_guiana",
            "french_polynesia",
            "french_southern_territories",
            "gabon",
            "gambia",
            "georgia",
            "germany",
            "ghana",
            "gibraltar",
            "greece",
            "greenland",
            "grenada",
            "guadeloupe",
            "guam",
            "guatemala",
            "guernsey",
            "guinea",
            "guinea_bissau",
            "guyana",
            "haiti",
            "heard_island_and_mcdonald_islands",
            "honduras",
            "hong_kong",
            "hungary",
            "iceland",
            "india",
            "indonesia",
            "iran",
            "iraq",
            "ireland",
            "isle_of_man",
            "israel",
            "italy",
            "jamaica",
            "japan",
            "jersey",
            "jordan",
            "kazakhstan",
            "kenya",
            "kiribati",
            "korea_north",
            "korea_south",
            "kosovo",
            "kuwait",
            "kyrgyzstan",
            "laos",
            "latvia",
            "lebanon",
            "lesotho",
            "liberia",
            "libya",
            "liechtenstein",
            "lithuania",
            "luxembourg",
            "macao",
            "macedonia",
            "madagascar",
            "malawi",
            "malaysia",
            "maldives",
            "mali",
            "malta",
            "marshall_islands",
            "martinique",
            "mauritania",
            "mauritius",
            "mayotte",
            "mexico",
            "micronesia",
            "moldova",
            "monaco",
            "mongolia",
            "montenegro",
            "montserrat",
            "morocco",
            "mozambique",
            "myanmar",
            "namibia",
            "nauru",
            "nepal",
            "netherlands",
            "new_caledonia",
            "new_zealand",
            "nicaragua",
            "niger",
            "nigeria",
            "niue",
            "norfolk_island",
            "northern_mariana_islands",
            "norway",
            "oman",
            "pakistan",
            "palau",
            "palestinian_territory",
            "panama",
            "papua_new_guinea",
            "paraguay",
            "peru",
            "philippines",
            "pitcairn_islands",
            "poland",
            "portugal",
            "puerto_rico",
            "qatar",
            "republic_of_china",
            "republic_of_the_congo",
            "reunion",
            "romania",
            "russia",
            "rwanda",
            "saint_barthelemy",
            "saint_helena",
            "saint_kitts_and_nevis",
            "saint_lucia",
            "saint_martin",
            "saint_pierre_and_miquelon",
            "saint_vincent_and_the_grenadines",
            "samoa",
            "san_marino",
            "sao_tome_and_principe",
            "saudi_arabia",
            "scotland",
            "senegal",
            "serbia",
            "seychelles",
            "sierra_leone",
            "singapore",
            "sint_maarten",
            "slovakia",
            "slovenia",
            "solomon_islands",
            "somalia",
            "south_africa",
            "south_georgia_and_the_south_sandwich_islands",
            "south_sudan",
            "spain",
            "sri_lanka",
            "sudan",
            "suriname",
            "svalbard_and_jan_mayen",
            "swaziland",
            "sweden",
            "switzerland",
            "syria",
            "tajikistan",
            "tanzania",
            "thailand",
            "togo",
            "tokelau",
            "tonga",
            "trinidad_and_tobago",
            "tunisia",
            "turkey",
            "turkmenistan",
            "turks_and_caicos_islands",
            "tuvalu",
            "uganda",
            "ukraine",
            "united_arab_emirates",
            "united_kingdom",
            "united_states_of_america",
            "uruguay",
            "ussr",
            "uzbekistan",
            "vanuatu",
            "vatican_city",
            "venezuela",
            "vietnam",
            "virgin_islands_british",
            "virgin_islands_us",
            "wales",
            "wallis_and_futuna",
            "western_sahara",
            "yemen",
            "zambia",
            "zimbabwe"});
            this.listBox1.Location = new System.Drawing.Point(300, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            // 
            // FlagViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlagViewer";
            this.Text = "FlagViewer";
            this.Load += new System.EventHandler(this.FlagViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

