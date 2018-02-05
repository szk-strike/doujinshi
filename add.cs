using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace 同人誌管理 {
    public partial class add : Form {
        public add() {
            InitializeComponent();
        }

        //登録ボタンの処理
        private void insert_Click(object sender, EventArgs e) {
            //SQL文組み立て

            //テスト用のINSERT文
            string query = "INSERT INTO t_doujinshi(ID,title,origin_ID,genre_ID,age_limit,date,"+
                "main_chara,place)VALUES(1,'慧音先生の情報リテラシー講座',1,1,1,'20180205','上白沢慧音',1); ";

            //SQLiteへのコネクト
            SQLiteConnection conn = new SQLiteConnection("Data Source = doujinshi.sqlite"); //カレントディレクトリに置く
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();
            try {
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch(Exception err) {
                MessageBox.Show(err.ToString());
            }


            //クエリ発行

            //テキストの全初期化
            
            //ID連番を回す
        }

        //閉じるボタンの処理
        private void close_Click(object sender, EventArgs e) {
            Visible = false;
        }

        //ロード時の処理
        private void add_Load(object sender, EventArgs e) {
            //  t_tableのIDの最大値を取得

            //新規IDをidに格納
            //id.Text=
        }
    }
}
