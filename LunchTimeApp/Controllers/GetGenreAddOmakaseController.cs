using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LunchTimeApp
{
    class GetGenreAddOmakaseController
    {
        /// <summary>
        /// DB接続しDataSetを取得、DataTable型に変更して戻す。
        /// </summary>
        /// <returns></returns>
        public List<ItemSet> GetGenreAddOmakase()
        {
            try
            {
                GenreModel genreModel = new GenreModel();
                DataTable genre = genreModel.GetGenre().Tables["GENRE_MASTER"];

                // 取得したDataTable型変数genreをListに代入
                List<ItemSet> genreList = new List<ItemSet>();
                foreach (DataRow row in genre.AsEnumerable())
                {
                    genreList.Add(new ItemSet((int)row[0], row[1].ToString()));
                }

                // 「お任せ！」の値と表示名をリストに追加
                genreList.Add(new ItemSet(0, "お任せ！"));
                return genreList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
