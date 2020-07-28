using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LunchTimeApp
{
    /// <summary>
    /// DBよりジャンルを取得するコントローラー
    /// </summary>
    class GetGenreController
    {
        /// <summary>
        /// DB接続しDataSetを取得、List<ItemSet>型に変更して戻すメソッド
        /// </summary>
        /// <returns>ItemSet型のList</returns>
        public List<ItemSet> GetGenre()
        {
            try
            {
                GenreModel genreModel = new GenreModel();
                DataTable genre = genreModel.GetGenre();

                // 取得したDataTable型変数genreをListに代入
                return genre.AsEnumerable().Select(row => new ItemSet((int)row[0], row[1].ToString())).ToList();

                // 旧コード(勉強用に記録しています)
                // foreach (DataRow row in genre.AsEnumerable())
                // {
                //     genreList.Add(new ItemSet((int)row[0], row[1].ToString()));
                // }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
