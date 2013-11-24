﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using NewLife.CMX.Config;
using NewLife.CMX.TemplateEngine;
using NewLife.CMX.Web;
using NewLife.Web;
using XCode;

namespace NewLife.CMX.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class ArticleModelList : IModeList
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dic"></param>
        public String Process()
        {
            try
            {
                Article.Meta.TableName += Suffix;
                ArticleCategory.Meta.TableName += Suffix;

                List<Article> Articles;
                List<ArticleCategory> Categories;

                ArticleCategory ac = ArticleCategory.FindByID(CategoryID);
                if (ac.IsEnd)
                {
                    Articles = Article.Search(null, CategoryID, null, Pageindex, RecordNum);
                    Categories = ArticleCategory.FindAllChildsNoParent(ac.ParentID);
                }
                else
                {
                    Categories = ArticleCategory.FindAllChildsNoParent(CategoryID).FindAll(delegate(ArticleCategory art)
                    {
                        return art.IsEnd == true;
                    });
                    ArticleCategory first = Categories[0];
                    Articles = Article.Search(null, first.ID, null, Pageindex, RecordNum);
                }

                Dictionary<String, String> dic = new Dictionary<string, string>();
                dic.Add("Address", Address);
                dic.Add("CategoryID", CategoryID.ToString());
                dic.Add("Suffix", Suffix);
                dic.Add("Pageindex", Pageindex.ToString());
                dic.Add("RecordNum", RecordNum.ToString());

                CMXEngine engine = new CMXEngine(TemplateConfig.Current);
                engine.ArgDic = dic;
                engine.ListEntity = Articles.ConvertAll<IEntity>(e => e as IEntity);
                engine.ListCategory = Categories.ConvertAll<IEntityTree>(e => e as IEntityTree);
                String content = engine.Render(Address + ".html");

                return content;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Article.Meta.TableName = "";
                ArticleCategory.Meta.TableName = "";
            }
        }

        private String _Suffix;
        /// <summary></summary>
        public String Suffix { get { return _Suffix; } set { _Suffix = value; } }

        private int _CategoryID;
        /// <summary></summary>
        public int CategoryID { get { return _CategoryID; } set { _CategoryID = value; } }

        private String _Address;
        /// <summary></summary>
        public String Address { get { return _Address; } set { _Address = value; } }

        private Int32 _Pageindex;
        /// <summary>页面索引</summary>
        public Int32 Pageindex { get { return _Pageindex; } set { _Pageindex = value; } }

        private Int32 _RecordNum;
        /// <summary>记录数</summary>
        public Int32 RecordNum { get { return _RecordNum; } set { _RecordNum = value; } }
    }
}