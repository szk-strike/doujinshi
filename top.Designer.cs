namespace 同人誌管理 {
    partial class top {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.searchKind = new System.Windows.Forms.ComboBox();
            this.word = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.detailSearch = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchKind
            // 
            this.searchKind.FormattingEnabled = true;
            this.searchKind.Location = new System.Drawing.Point(25, 42);
            this.searchKind.Name = "searchKind";
            this.searchKind.Size = new System.Drawing.Size(121, 20);
            this.searchKind.TabIndex = 0;
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(192, 42);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(456, 19);
            this.word.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(25, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "検索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // detailSearch
            // 
            this.detailSearch.Location = new System.Drawing.Point(573, 67);
            this.detailSearch.Name = "detailSearch";
            this.detailSearch.Size = new System.Drawing.Size(75, 23);
            this.detailSearch.TabIndex = 3;
            this.detailSearch.Text = "詳細検索";
            this.detailSearch.UseVisualStyleBackColor = true;
            this.detailSearch.Click += new System.EventHandler(this.detailSearch_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(25, 97);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(623, 271);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(25, 397);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 51);
            this.add.TabIndex = 5;
            this.add.Text = "新規追加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "テーブル管理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(548, 397);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 51);
            this.close.TabIndex = 7;
            this.close.Text = "閉じる";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.detailSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.word);
            this.Controls.Add(this.searchKind);
            this.Name = "top";
            this.Text = "同人誌管理";
            this.Load += new System.EventHandler(this.top_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchKind;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button detailSearch;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
    }
}

