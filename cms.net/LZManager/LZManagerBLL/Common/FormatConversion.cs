using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LZManager.BLL.Common
{
     public  class FormatConversion
    {
        private const long NUMBER_YI = 100000000;
        private const long NUMBER_WAN = 10000;

        /// <summary>
        /// 格式化金币数量，格式为：XXXX亿XXXX万XXXX
        /// </summary>
        /// <param name="goldNumber"></param>
        /// <returns></returns>
        public static String FormatGoldNumber(long goldNumber)
        {
            String sign = ""; //正负
            if (goldNumber < 0)
            {
                sign = "负";
                goldNumber = Math.Abs(goldNumber);
            }
            int yiNum = 0;
            int wanNum = 0;
            long tmpGoldNumber = goldNumber;
            if (goldNumber >= NUMBER_YI)
            {
                yiNum = Convert.ToInt32(goldNumber / NUMBER_YI);
                tmpGoldNumber = goldNumber - (yiNum * NUMBER_YI);
            }
            if (tmpGoldNumber >= NUMBER_WAN)
            {
                wanNum = Convert.ToInt32(tmpGoldNumber / NUMBER_WAN);
                tmpGoldNumber = tmpGoldNumber - (wanNum * NUMBER_WAN);
            }

            //拼字符串
            StringBuilder sbGoldNumber = new StringBuilder(sign);
            if (yiNum > 0)
            {
                sbGoldNumber.Append(yiNum).Append("亿");
                if (wanNum == 0 && tmpGoldNumber > 0)
                {
                    sbGoldNumber.Append(wanNum).Append("万"); //亿不为0，万为0并且千位以下不为0时显示“0万”
                }
            }
            if (wanNum > 0)
            {
                sbGoldNumber.Append(wanNum).Append("万");
            }
            if (tmpGoldNumber > 0)
            {
                sbGoldNumber.Append(tmpGoldNumber);
            }

            if (yiNum == 0
                && wanNum == 0
                && tmpGoldNumber == 0)
            {
                sbGoldNumber.Append(tmpGoldNumber);
            }

            return sbGoldNumber.ToString();
        }
    }
}
