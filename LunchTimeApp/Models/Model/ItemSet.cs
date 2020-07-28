namespace LunchTimeApp.Models.Model
{
    /// <summary>
    /// DBからデータを取得しフォームに格納する際の
    /// 「値」と「表示名」を分けてセットするクラス
    /// </summary>
    public class ItemSet
    {
        public int ItemValue { get; set; }
        public string ItemDisp { get; set; }

        /// <summary>
        /// 値(value)と表示名(display)を分けているコンストラクタ
        /// </summary>
        /// <param name="value">値(ID)</param>
        /// <param name="display">フォームに表示される名前</param>
        public ItemSet(int value, string display)
        {
            ItemValue = value;
            ItemDisp = display;
        }
    }
}
