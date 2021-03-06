﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_FamilyBaseInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_FamilyBaseInfo
	{
		public record_FamilyBaseInfo()
		{}
		#region Model
		private int _fimaryid;
		private string _f_fimarycode;
		private int _f_userid;
		private int _f_groupid;
		private string _f_fimarytel="";
		private string _f_fimrayaddress="";
		private int? _f_housetype=0;
		private decimal? _f_housearea=0M;
		private int? _f_ventilation=0;
		private int? _f_humidity=0;
		private int? _f_warm=0;
		private int? _f_lighting=0;
		private int? _f_sanitation=0;
		private int? _f_kitchen=0;
		private int? _f_fuel=0;
		private int? _f_water=0;
		private int? _f_wastedisposal=0;
		private int? _f_livestockbar=0;
		private int? _f_toilettype=0;
		private int _f_responsibilityuserid;
		private int _f_fillinguserid;
		/// <summary>
		/// 自增家庭ID号
		/// </summary>
		public int FimaryID
		{
			set{ _fimaryid=value;}
			get{return _fimaryid;}
		}
		/// <summary>
		/// 家庭档案编号，由12位居（村）委会行政代码+自增的FimaryID组成
		/// </summary>
		public string F_FimaryCode
		{
			set{ _f_fimarycode=value;}
			get{return _f_fimarycode;}
		}
		/// <summary>
		/// 户主，与sys_User表的UserID关联
		/// </summary>
		public int F_UserID
		{
			set{ _f_userid=value;}
			get{return _f_userid;}
		}
		/// <summary>
		/// 村(居)委会ID，与sys_Group表中GroupID关联
		/// </summary>
		public int F_GroupID
		{
			set{ _f_groupid=value;}
			get{return _f_groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_FimaryTel
		{
			set{ _f_fimarytel=value;}
			get{return _f_fimarytel;}
		}
		/// <summary>
		/// 家庭地址
		/// </summary>
		public string F_FimrayAddress
		{
			set{ _f_fimrayaddress=value;}
			get{return _f_fimrayaddress;}
		}
		/// <summary>
		/// 房屋类型 1:砖瓦平房，2:砖瓦楼房，3:土屋，4:茅屋，5:木屋
		/// </summary>
		public int? F_HouseType
		{
			set{ _f_housetype=value;}
			get{return _f_housetype;}
		}
		/// <summary>
		/// 居住面积
		/// </summary>
		public decimal? F_HouseArea
		{
			set{ _f_housearea=value;}
			get{return _f_housearea;}
		}
		/// <summary>
		/// 通风 1:好，2:一般，3:差
		/// </summary>
		public int? F_Ventilation
		{
			set{ _f_ventilation=value;}
			get{return _f_ventilation;}
		}
		/// <summary>
		/// 湿度 1:潮湿，2:干燥，3:一般
		/// </summary>
		public int? F_Humidity
		{
			set{ _f_humidity=value;}
			get{return _f_humidity;}
		}
		/// <summary>
		/// 保暖 1:好，2:一般，3:差
		/// </summary>
		public int? F_Warm
		{
			set{ _f_warm=value;}
			get{return _f_warm;}
		}
		/// <summary>
		/// 采光 1:好，2:一般，3:差
		/// </summary>
		public int? F_Lighting
		{
			set{ _f_lighting=value;}
			get{return _f_lighting;}
		}
		/// <summary>
		/// 卫生 1:清洁，2:一般，3:较脏，4:差
		/// </summary>
		public int? F_Sanitation
		{
			set{ _f_sanitation=value;}
			get{return _f_sanitation;}
		}
		/// <summary>
		/// 厨房 1:合用，2:独用，3:无
		/// </summary>
		public int? F_Kitchen
		{
			set{ _f_kitchen=value;}
			get{return _f_kitchen;}
		}
		/// <summary>
		/// 使用燃料 1：液化气，2：煤气，3:天然气，4:沼气，5:柴火，6:其他
		/// </summary>
		public int? F_Fuel
		{
			set{ _f_fuel=value;}
			get{return _f_fuel;}
		}
		/// <summary>
		/// 饮水来源 1：自来水，2：经净化过滤的水，3：井水，4：河湖水，5：塘水口，6：桶装水，7：其他
		/// </summary>
		public int? F_Water
		{
			set{ _f_water=value;}
			get{return _f_water;}
		}
		/// <summary>
		/// 垃圾处理 1：垃圾处理，2：垃圾箱，3：其他
		/// </summary>
		public int? F_WasteDisposal
		{
			set{ _f_wastedisposal=value;}
			get{return _f_wastedisposal;}
		}
		/// <summary>
		/// 禽畜栏 1：单设，2：室内，3：室外
		/// </summary>
		public int? F_LivestockBar
		{
			set{ _f_livestockbar=value;}
			get{return _f_livestockbar;}
		}
		/// <summary>
		/// 厕所类型 1：家庭卫生厕所：三格式粪池式，2：家庭卫生厕所：双瓮漏斗式，3：家庭卫生厕所：三联沼气池式，4：家庭卫生厕所：粪尿分集式，5：家庭卫生厕所：完整下水道水冲式，6：家庭卫生厕所：双坑交替式，7：非卫生厕所：一格或两格粪池式，8：非卫生厕所：马桶，9：非卫生厕所：露天粪坑，10：非卫生厕所：简易棚厕
		/// </summary>
		public int? F_ToiletType
		{
			set{ _f_toilettype=value;}
			get{return _f_toilettype;}
		}
		/// <summary>
		/// 责任人，与sys_User表中的UerID关联
		/// </summary>
		public int F_ResponsibilityUserID
		{
			set{ _f_responsibilityuserid=value;}
			get{return _f_responsibilityuserid;}
		}
		/// <summary>
		/// 建档人，与sys_User表中的UerID关联
		/// </summary>
		public int F_FillingUserID
		{
			set{ _f_fillinguserid=value;}
			get{return _f_fillinguserid;}
		}
		#endregion Model

	}
}

