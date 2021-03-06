﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.record_HealthCheck
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtH_BodyTemperature.Text))
			{
				strErr+="体温格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_PulseRate.Text))
			{
				strErr+="脉率（次/min）格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_RespiratoryRate.Text))
			{
				strErr+="呼吸频率（次/min）格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_LeftDiastolic.Text))
			{
				strErr+="左侧舒张压(mmHg)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_LeftSystolic.Text))
			{
				strErr+="左侧收缩压(mmHg)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_RightDiastolic.Text))
			{
				strErr+="右侧舒张压(mmHg)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_RightSystolic.Text))
			{
				strErr+="右侧收缩压(mmHg)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_Height.Text))
			{
				strErr+="身高（cm）格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_Weight.Text))
			{
				strErr+="体重（kg）格式错误！\\n";	
			}
			if(this.txtH_Result.Text.Trim().Length==0)
			{
				strErr+="体检结果不能为空！\\n";	
			}
			if(this.txtH_Suggestion.Text.Trim().Length==0)
			{
				strErr+="体检建议不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtH_CheckTime.Text))
			{
				strErr+="体检时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_MedicalInstitutions.Text))
			{
				strErr+="体检机构格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtH_CheckUserID.Text))
			{
				strErr+="体检医生格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			decimal H_BodyTemperature=decimal.Parse(this.txtH_BodyTemperature.Text);
			int H_PulseRate=int.Parse(this.txtH_PulseRate.Text);
			int H_RespiratoryRate=int.Parse(this.txtH_RespiratoryRate.Text);
			int H_LeftDiastolic=int.Parse(this.txtH_LeftDiastolic.Text);
			int H_LeftSystolic=int.Parse(this.txtH_LeftSystolic.Text);
			int H_RightDiastolic=int.Parse(this.txtH_RightDiastolic.Text);
			int H_RightSystolic=int.Parse(this.txtH_RightSystolic.Text);
			int H_Height=int.Parse(this.txtH_Height.Text);
			int H_Weight=int.Parse(this.txtH_Weight.Text);
			string H_Result=this.txtH_Result.Text;
			string H_Suggestion=this.txtH_Suggestion.Text;
			DateTime H_CheckTime=DateTime.Parse(this.txtH_CheckTime.Text);
			int H_MedicalInstitutions=int.Parse(this.txtH_MedicalInstitutions.Text);
			int H_CheckUserID=int.Parse(this.txtH_CheckUserID.Text);

			Maticsoft.Model.record_HealthCheck model=new Maticsoft.Model.record_HealthCheck();
			model.H_BodyTemperature=H_BodyTemperature;
			model.H_PulseRate=H_PulseRate;
			model.H_RespiratoryRate=H_RespiratoryRate;
			model.H_LeftDiastolic=H_LeftDiastolic;
			model.H_LeftSystolic=H_LeftSystolic;
			model.H_RightDiastolic=H_RightDiastolic;
			model.H_RightSystolic=H_RightSystolic;
			model.H_Height=H_Height;
			model.H_Weight=H_Weight;
			model.H_Result=H_Result;
			model.H_Suggestion=H_Suggestion;
			model.H_CheckTime=H_CheckTime;
			model.H_MedicalInstitutions=H_MedicalInstitutions;
			model.H_CheckUserID=H_CheckUserID;

			Maticsoft.BLL.record_HealthCheck bll=new Maticsoft.BLL.record_HealthCheck();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
