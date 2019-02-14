using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 应答体
    /// </summary>
    public class ResponseDetail
    {
        /// <summary>
        /// 动作列表
        /// </summary>
        [JsonProperty("action_list")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// 解析的词槽与意图
        /// </summary>
        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        /// <summary>
        /// 解析结果
        /// </summary>
        [JsonProperty("qu_res")]
        public QueryResult QueryResult { get; set; }
    }

    /// <summary>
    /// 动作
    /// </summary>
    public class Action
    {
        /// <summary>
        /// 动作置信度
        /// </summary>
        [JsonProperty("confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// 动作ID
        /// </summary>
        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        /// <summary>
        /// 应答话术
        /// </summary>
        [JsonProperty("say")]
        public string Say { get; set; }

        /// <summary>
        /// 用户自定义应答，如果action_type未event
        /// </summary>
        [JsonProperty("custom_reply")]
        public string CustomReply { get; set; }

        /// <summary>
        /// 类型，对应如下understood（理解达成）/failure（理解失败）/chat（聊天话术）/event（触发事件）
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 泛澄清时，即type未clarify/guide/faqguide有效
        /// </summary>
        [JsonProperty("refine_detail")]
        public Refine RefineDetail { get; set; }
    }

    public class Refine
    {
        /// <summary>
        /// 具有以下 select/ask/selectandask
        /// </summary>
        [JsonProperty("interact")]
        public string Interact { get; set; }

        [JsonProperty("option_list")]
        public List<Option> OptionList { get; set; }

        /// <summary>
        /// clarify有效，表明起因
        /// </summary>
        [JsonProperty("clarify_reason")]
        public string ClarifyReason { get; set; }
    }

    /// <summary>
    /// 选项列表
    /// </summary>
    public class Option
    {
        /// <summary>
        /// 选项文字
        /// </summary>
        [JsonProperty("option")]
        public string Name { get; set; }

        /// <summary>
        /// 选项细节信息
        /// </summary>
        [JsonProperty("info")]
        public object Info { get; set; }
    }

    /// <summary>
    /// 解析的意图、词槽
    /// </summary>
    public class Schema
    {
        /// <summary>
        /// 意图信息
        /// </summary>
        [JsonProperty("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// 意图置信度
        /// </summary>
        [JsonProperty("intent_confidence")]
        public float IntentConfidence { get; set; }

        /// <summary>
        /// Domain分类置信度
        /// </summary>
        [JsonProperty("domain_confidence")]
        public float DomainConfidence { get; set; }

        /// <summary>
        /// 词槽列表
        /// </summary>
        [JsonProperty("slots")]
        public List<Slot> Slots { get; set; }
    }

    /// <summary>
    /// 词槽
    /// </summary>
    public class Slot
    {
        /// <summary>
        /// 词槽置信度
        /// </summary>
        [JsonProperty("confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// 词槽起始
        /// </summary>
        [JsonProperty("begin")]
        public int Begin { get; set; }

        /// <summary>
        /// 词槽长度
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }

        /// <summary>
        /// 词槽值
        /// </summary>
        [JsonProperty("original_word")]
        public string OriginalWord { get; set; }

        /// <summary>
        /// 归一化词槽值
        /// </summary>
        [JsonProperty("normalized_word")]
        public string NormalizedWord { get; set; }

        /// <summary>
        /// 词槽值细化类型
        /// </summary>
        [JsonProperty("word_type")]
        public string WordType { get; set; }

        /// <summary>
        /// 词槽名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 词槽事第一轮对话中引入的
        /// </summary>
        [JsonProperty("session_offset")]
        public int SessionOffset { get; set; }

        /// <summary>
        /// 引入的方式
        /// </summary>
        [JsonProperty("merge_method")]
        public string MergeMethod { get; set; }

        /// <summary>
        /// 子词槽
        /// </summary>
        [JsonProperty("sub_slots")]
        public List<Slot> SubSlots { get; set; }
    }

    /// <summary>
    /// 解析结果
    /// </summary>
    public class QueryResult
    {
        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("timestamp")]
        public int TimeStamp { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 原始查询
        /// </summary>
        [JsonProperty("raw_query")]
        public string RawQuery { get; set; }

        /// <summary>
        /// 意图候选项
        /// </summary>
        [JsonProperty("candidates")]
        public List<Candidate> Candidates { get; set; }

        /// <summary>
        /// 最终qu结果
        /// </summary>
        [JsonProperty("qu_res_chosen")]
        public string QueryResultChosen { get; set; }

        /// <summary>
        /// 词法分析结果
        /// </summary>
        [JsonProperty("lexical_analysis")]
        public List<LexicalAnalysis> LexicalAnalysis { get; set; }

        /// <summary>
        /// 情感分析结果
        /// </summary>
        [JsonProperty("sentiment_analysis")]
        public SentimentAnalysis SentimentAnlysis { get; set; }
    }

    /// <summary>
    /// 意图候选项
    /// </summary>
    public class Candidate
    {
        /// <summary>
        /// 整体置信度
        /// </summary>
        [JsonProperty("confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// 候选项意图名称
        /// </summary>
        [JsonProperty("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// 候选项意图置信度
        /// </summary>
        [JsonProperty("intent_confidence")]
        public float IntentConfidence { get; set; }

        /// <summary>
        /// 候选项domain分类置信度
        /// </summary>
        [JsonProperty("domain_confidence")]
        public float DomainConfidence { get; set; }

        /// <summary>
        /// 意图是否需要澄清
        /// </summary>
        [JsonProperty("intent_need_clarify")]
        public bool IntentNeedClarify { get; set; }

        /// <summary>
        /// 词槽
        /// </summary>
        [JsonProperty("slots")]
        public List<IntentSlot> Slots { get; set; }

        /// <summary>
        /// 来去哪个qu策略
        /// </summary>
        [JsonProperty("from_who")]
        public string FromWho { get; set; }

        /// <summary>
        /// query匹配信息
        /// </summary>
        [JsonProperty("math_info")]
        public string MatchInfo { get; set; }

        /// <summary>
        /// 候选项附加信息
        /// </summary>
        [JsonProperty("extra_info")]
        public ExtraInfo ExtraInfo { get; set; }
    }

    /// <summary>
    /// 意图词槽
    /// </summary>
    public class IntentSlot
    {
        /// <summary>
        /// 词槽置信度
        /// </summary>
        [JsonProperty("confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        [JsonProperty("begin")]
        public int Begin { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }

        /// <summary>
        /// 词槽原始值
        /// </summary>
        [JsonProperty("original_word")]
        public string OriginalWord { get; set; }

        /// <summary>
        /// 词槽归一化值
        /// </summary>
        [JsonProperty("normalized_wrod")]
        public string NormalizedWord { get; set; }

        /// <summary>
        /// 细粒度词槽类型
        /// </summary>
        [JsonProperty("word_type")]
        public string WordType { get; set; }

        /// <summary>
        /// 词槽名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 词槽是否需要澄清
        /// </summary>
        [JsonProperty("need_clarify")]
        public bool NeedClarify { get; set; }

        /// <summary>
        /// 父词槽索引
        /// </summary>
        [JsonProperty("father_idx")]
        public int FatherIdx { get; set; }
    }

    /// <summary>
    /// 词法分析
    /// </summary>
    public class LexicalAnalysis
    {
        /// <summary>
        /// 词汇
        /// </summary>
        [JsonProperty("term")]
        public string Term { get; set; }

        /// <summary>
        /// 重要性权重
        /// </summary>
        [JsonProperty("weight")]
        public float Weight { get; set; }

        /// <summary>
        /// 词性或专名类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        
        /// <summary>
        /// 词汇的基本词
        /// </summary>
        [JsonProperty("basic_word")]
        public List<string> BasicWord { get; set; }
    }

    /// <summary>
    /// 情感分析结果
    /// </summary>
    public class SentimentAnalysis
    {
        /// <summary>
        /// 情感标签
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// 置信度
        /// </summary>
        [JsonProperty("pval")]
        public float Pval { get; set; }
    }

    public class ExtraInfo
    {
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("real_threshold")]
        public string RealThreshold { get; set; }

        [JsonProperty("threshold")]
        public double ThresHold { get; set; }
    }
}
