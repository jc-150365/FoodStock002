using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FoodStock01
{
    [Table("Stock")]//テーブル名を指定
    public class StockFoodModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int S_no { get; set; } //保存食材No

        public string S_name { get; set; } //保存食材名

        public int S_qty { get; set; } //数量

        public string F_limit { get; set; } //現在時刻との差（後で使うかも）

        public TimeSpan F_span { get; set; } //現在日時との差（後で使うかも）

        public int F_result { get; set; } //現在日時との差（後で使うかも）

        /********************インサートメソッド*********************/
        /*public static void InsertFood(int f_no, string f_name,DateTime f_date)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<FoodModel>();
                    db.Insert(new FoodModel() { F_no = f_no, F_name = f_name, F_date = f_date });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }*/

        /********************インサートメソッド**********************/
        public static void InsertFood(int f_no, string f_name, int f_result)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<FoodModel>();

                    db.Insert(new FoodModel() { F_no = f_no, F_name = f_name, F_result = f_result });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /*******************セレクトメソッド**************************************/
        public static List<FoodModel> SelectFood()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースに指定したSQLを発行
                    return db.Query<FoodModel>("SELECT * FROM [Food] ORDER BY [F_result]");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }

        /********************デリートメソッド*************************************/
        public static void DeleteFood(int f_no)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<FoodModel>();

                    db.Delete<FoodModel>(f_no);//デリートで渡す値は主キーじゃないといけない説
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************オールデリートメソッド*************************************/
        public static void DeleteAllFood()
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<FoodModel>();

                    db.DeleteAll<FoodModel>();//デリートで渡す値は主キーじゃないといけない説
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************アップデートメソッド**************************************/
        public static List<FoodModel> UpdateFood()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースに指定したSQLを発行
                    return db.Query<FoodModel>("UPDATE [Food] SET ");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }
    }
}