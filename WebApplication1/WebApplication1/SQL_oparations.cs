﻿using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WebApplication1.Models;
using WebApplication1.Controllers;

//using Windows.UI.Xaml.Controls;
using System.Windows;

namespace Tinder
{
	public class SQL_oparations
	{
		static DataSet TinderUserInfoDB = new DataSet(); // DBのすべての内容を格納する変数
		//private  DataSet RetriveWholeDB(object sender, EventArgs e)
		 public static DataSet RetriveWholeDB()
		{
			//// MySQLへの接続
			try
			{
				// コネクション作成
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter(
				 "SELECT * FROM tinderuserinfo", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;
				FirstAdapter.Fill(TinderUserInfoDB, "tinderuserinfo");
				// jsonに変換する場合
				String TinderUserInfoJson = Newtonsoft.Json.JsonConvert.SerializeObject(TinderUserInfoDB);
				DefaultController SentJson = new DefaultController();
				// SentJson.Post(TinderUserInfoJson);


				//DataTable dt = new DataTable();
				//Console.WriteLine(TinderUserInfoDB.Tables["tinderuserinfo"].Rows[0]["age"]);
				/*foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
				{

					Console.WriteLine("{0}, {1}", pRow["age"], pRow["id"]);
				}
				*/

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}

			return TinderUserInfoDB;
		}

		//sign upして送られてきたデータをdatabaseに格納
		 public static void INSERT_DATA(person data)
		{
			try
			{
				// コネクション作成
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");

				// コマンドを作成
				MySqlCommand cmd =
					new MySqlCommand("insert into tinderuserinfo values (@id, @username, @age, @sex, @whoami, @liked )", cn);
				// パラメータ設定
				// 実際には取得した値が入ります。
				cmd.Parameters.Add(new MySqlParameter("id", DateTime.Now)); // Primary key として時刻を選択
				cmd.Parameters.Add(new MySqlParameter("username", "test"));
				cmd.Parameters.Add(new MySqlParameter("age", 1));
				cmd.Parameters.Add(new MySqlParameter("sex", 1)); // man : 1 woman : 0
				cmd.Parameters.Add(new MySqlParameter("whoami", "test"));
				cmd.Parameters.Add(new MySqlParameter("liked", 1));

				// オープン
				cmd.Connection.Open();
				// 実行
				cmd.ExecuteNonQuery();
				// クローズ
				cmd.Connection.Close();

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}
		}

		//ランキング情報を取得する関数
		//何人まで取得するか検討中
		//返り値をstring(json)型にするか、person型にするか決定してません。
		// person型にするならコレクションとかを使ってperson型の配列のような物を作るのがよいかと思います。
		public static void SELECT_RANK()
		{
			try
			{
				// コネクション作成
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");

				// Likedが大きい順に並べて上位5人まで出力する
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter("SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 5", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;
		
				DataSet RankingByLike5 = new DataSet(); 
				FirstAdapter.Fill(RankingByLike5, "tinderuserinfo"); // 出力結果をDatasetに格納
				
				// とりあえず、Dataset型にしておいたのでPerson型にするかjsonにするかお任せします。 

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}
		}


		//データベースからランダムでSELECT
		//ランダム関数を使ってIDを決定する。ランダム値は最古IDから最新IDの中で発生(自分のIDも含まれてしまう可能性もあるがそれはまた後で)
		  public static void SELECT_RND()
		{
			RetriveWholeDB();

			List<DateTime> IDs = new List<DateTime>();
			foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
			{
				IDs.Add((DateTime)pRow["id"]);
			}

			Random RandomNum = new System.Random();
			int Selector = RandomNum.Next(0, IDs.Count());
			DateTime Selectedid = (DateTime)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[Selector]["id"];
			var SelectedUserName = TinderUserInfoDB.Tables["tinderuserinfo"].Rows[Selector]["username"];
			// ....
			Console.WriteLine(Selectedid); // 選ばれた人のidを出力



		}

		//いいねをカウントアップする関数 defaultcontrollerから引数IDを取得して該当するデータを変更する。
		public static void INSERT_THUMBS(int id)
		{
			//SQL conection
			//SQL 引数のID を使って 該当のデータのいいね数を+1でupdate 
			//SQL conection

			try
			{   // 特定の名前の人の言い値数をユーザ名(できたらid)で取得する
				// idでの指定が上手くいかないかもしれないのでprimary keyをユーザ名に変更するかもしれません.
				string username = "test"; // ここに++1したいユーザ名を格納

				// コネクション作成
				MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				int LikeCount = 0; // 初期化
				RetriveWholeDB();
				Console.WriteLine(TinderUserInfoDB.Tables["tinderuserinfo"].Rows[(int)1]["username"]);
				foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
				{
					if ((string)pRow["username"] == username)
					{
						LikeCount = (int)(pRow["liked"]);
					}
				}



				// testというユーザの言い値を現在のいいね数+1に変更する処理
				// コマンドを作成
				MySqlCommand cmd = new MySqlCommand("update tinderuserinfo set liked=@liked where username=@username", cn);
				// パラメータ設定
				cmd.Parameters.Add(new MySqlParameter("username", username));
				int AfterLiked = LikeCount + 1;
				cmd.Parameters.Add(new MySqlParameter("liked", AfterLiked));
				// オープン
				cmd.Connection.Open();
				// 実行
				cmd.ExecuteNonQuery();
				// クローズ
				cmd.Connection.Close();

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}


		}

		//データベースとのコネクションを確立させる関数
		//あったほうがスッキリしそう。
		//作ったとしてそれぞれの関数内でconnectionをcloseするのをお忘れなく
		public static void CONNECTION()
		{

		}

	}
}
