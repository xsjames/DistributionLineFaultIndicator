﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionLineFaultIndicator
{
    class DataCollection
    {

        public static int linklen;      //
        public static int cotlen;//
        public static int publen;      //
        public static int inflen;

        public static UInt16 DevAddr;
        public static int YkStartPos;
        public static int ParamInfoAddr;

        public static byte addselect = 2;//
        public static byte seqflag;      //
        public static byte seq;      //
        public static byte SQflag;      //
        public static byte ZDYtype;

        public static byte DataTy;

        public static int linkState = 0;   //链路状态指示符，0为未初始化，1为已收到链路状态请求确认，2为已收到链路复位确认。
        public static int waitTime = 10;  //重发等待时间
        public static int class2Delay;
        public static int class2Delay_default;

        public static int trial;   //测试专用量

        public struct Channel1        //监测单元连接参数
        {
            public static string comID;
            public static string baud;
            public static string parity;
            public static string stopBits;
            public static string ip;
            public static string port;
        }

        public struct Channel2        //故障指示器连接参数
        {
            public static string comID;
            public static string baud;
            public static string parity;
            public static string stopBits;
            public static string ip;
            public static string port;
        }

        public struct _ProtocoltyFlag
        {
            public static int ACD;
            public static int FCB;
            public static int NetProFlag;
            public static int ComProFlag;
            public static int DelayTime;//重发时间

            public static int ZZTime;//总召循环时间
            public static bool Test101;
            public static bool Test104;
            public static bool ZZFlag;  //
            public static bool ZZFirstFlag;  //
            public static bool AloneCallYxYcFlag;



        }

        public struct _DataField
        {
            public static byte[] Buffer = new byte[1024];

            public static int FieldLen;
            public static int FieldVSQ;

        }

        //------------------------------------------------------------------------串口数据缓存
        public struct _ComStructData
        {
            public static byte[] RXBuffer = new byte[1024];
            public static byte[] TXBuffer = new byte[1024];
            public static int TxLen;
            public static int RxLen;
            public static bool TX_TASK;
            public static bool FCB = false;

        }

        public struct _ComStructData2
        {
            public static byte[] RXBuffer = new byte[1024];
            public static byte[] TXBuffer = new byte[1024];
            public static int TxLen;
            public static int RxLen;
            public static bool TX_TASK;
            public static bool FCB = false;

        }
        //------------------------------------------------------------------------串口任务处理
        public struct _ComTaskFlag
        {
            public static bool C_P1_NA_F;
            public static bool C_RQ_NA_LINKREQ_F;//请求链路状态
            public static bool C_RQ_NA_LINKREQ_F1;//复位链路
            public static bool C_RQ_NA_LINKCOM_F;//请求链路状态确认
            public static bool C_RQ_NA_LINKCOM_F1;//复位链路确认
            public static bool FirstON_S;
            public static bool SET_PARAM_CON;
            public static bool C_CS_NA_1;             //对时
            public static bool C_IC_NA_1;
            public static bool CALL_1;//
            public static bool CALL_2;//
            public static bool YK_Sel_1;
            public static bool YK_Exe_1;
            public static bool YK_Cel_1;
            public static bool VERSION_1;
            public static bool CALLTIME_1;
            public static bool READ_P_1;
            public static bool AloneCallYc_1;
            public static bool AloneCallYx_1;
            public static bool AloneCallYx_2;
            public static bool UpdateCode_Start_1;
            public static bool UpdateCode_JY_1;
            public static bool UpdateCode_OK_1;
            public static bool UpdateCode_ARMStart_1;
            public static bool UpdateCode_ARMJY_1;
            public static bool UpdateCode_ARMOK_1;
            public static bool Reset_1;
            public static bool CallHisData;
            public static bool CallRecordData;
            public static bool FuGuiCmd;
            public static bool YK_Sel_1_D;
            public static bool YK_Exe_1_D;
            public static bool YK_Cel_1_D;
            public static bool READ_Hard_1;
            public static bool READ_RYB_1;
            public static bool SET_RYB_1;

            public static bool Transmit; //数据转发
        }


       



        //下发监视端系统参数
        public struct SystemParam
        {
            public static byte AddrByteNum_101;
            public static byte CauseByteNum_101;
            public static byte PubAddByteNum_101;
            public static UInt16 Addr;                    //终端地址     
            public static UInt16 HeartBeatTime;            //心跳遥信发送周期 单位 min
            public static UInt16 BeatCycle;                  //GPRS心跳，以后作为GPRS模块休眠的周期
            public static UInt16 ComFrameSTime;
            public static UInt16 NormalVoltageRating;
            public static UInt16 NormalCurrentRating;
            public static UInt16 PubAddr_101;
            public static UInt16 RequestTime;               //发送请求链路的持续时间单位1ms
        }

        //下发监视端ip参数
        public struct _GPRSComSet
        {
            public static byte[] main_IP=new byte[4];
            public static UInt16 main_Port;
            public static byte[] res_IP=new byte[4];
            public static UInt16 res_Port;
            public static char[] APN=new char[16];
        }





        
        //故障指示器发送速率及带宽等设置设置参数
        public static byte[] MDMCFG0;
        public static byte[] MDMCFG1;
        public static byte[] MDMCFG2;
        public static byte[] MDMCFG3;
        public static byte[] MDMCFG4;

        
        //下设参数
        public static UInt16[] quickBreakSwitch;//速断投退（0或1）
        public static UInt16[] quickBreakValue;//速断定值（0~1000.0）
        public static UInt16[] quickBreakTime;//速断时间定值（0~65535）
        public static UInt16[] overCurrentSwitch;//过流投退(0或1)
        public static UInt16[] overCurrentValue;//过流定值（0~800）
        public static UInt16[] overCurrentTime;//过流时间定值（0~65535）
        public static UInt16[] freeCurrentValue;//无流定值（0~100.0）
        public static UInt16[] freeCurrentTime;//无流时间定值（0~65535）
        public static UInt16[] flashyFlowTime;//涌流时间定值（0~65535）
        public static UInt16[] selfAdaptionSwitch;//自适应投退（0或1）


        public static UInt16[] indtrAdds;//故障指示器地址
        public static UInt16[] rate;//发送速率
        public static UInt16[] bandWidth;//带宽
        public static UInt16[] tgz;
        public static UInt16[] tfgs;
        public static UInt16[] res3;
        public static UInt16[] res4;



        public static byte[] calibration;//校准（0或1）
        public static byte[] manualReset;//手动校准（0或1）

        public static byte[] res1;
        public static byte[] res2;






        //接收参数
        public static byte[] heartBeats;           //指示单元心跳（0或1；1-发生）
        public static byte[] shortCircuist;           //短路故障（0或1；1-发生）
        public static byte[] groundFaults;           //接地故障（0或1；1-发生）
        public static byte[] powerOns;             //线路上电（0或1；1-翻牌）
        public static byte[] powerOffs;              //线路停电（0或1；1-上电）
        public static byte[] shortCircuitTypes;               //短路故障性质（1或2；1-瞬时性，2-永久性）
        public static float[] loadCurrents;          //负荷电流（0~1000）
        public static float[] cellVoltages;             //电池电压（0~100）








        public struct YcData
        {
            public static int num;
            public static string[] name;
            public static string[] addr;
            public static string[] value;
        }

        public struct YxData
        {
            public static int num;
            public static string[] name;
            public static string[] addr;
            public static string[] value;
        }

















        //初始化参数
        public static void initializeData()
        { 
            //初始化接收参数,3路监测单元
            heartBeats=new byte[9];
            shortCircuist = new byte[9];     
            groundFaults=new byte[9];      
            powerOns=new byte[9];          
            powerOffs=new byte[9];         
            shortCircuitTypes=new byte[9]; 
            loadCurrents=new float[9];     
            cellVoltages=new float[9];
            for (int i = 0; i < 9; i++)
            {
                heartBeats[i] = shortCircuist[i] = groundFaults[i] = powerOns[i] =powerOffs[i] = shortCircuitTypes[i]=(byte)i;
                loadCurrents[i] = cellVoltages[i] = i;
            }
            //初始化下设参数，3路监测单元（每个单元含3个故障指示器）
            quickBreakSwitch = new ushort[9];
            quickBreakValue = new ushort[9];
            quickBreakTime=new ushort[9];
            overCurrentSwitch = new ushort[9];
            overCurrentValue = new ushort[9];
            overCurrentTime = new ushort[9];
            freeCurrentValue = new ushort[9];
            freeCurrentTime = new ushort[9];
            flashyFlowTime = new ushort[9];
            selfAdaptionSwitch = new ushort[9];
            indtrAdds = new ushort[9];//
            rate=new ushort[9];//
            bandWidth=new ushort[9];//
            tgz=new ushort[9];
            tfgs=new ushort[9];
            res3=new ushort[9];
            res4=new ushort[9];

            calibration = new byte[9];
            manualReset = new byte[9];
            res1 = new byte[9];
            res2 = new byte[9];
            for (int i = 0; i < 9; i++)
            {
                quickBreakSwitch[i] = overCurrentSwitch[i] = selfAdaptionSwitch[i] = (ushort)i;
                quickBreakValue[i] = overCurrentValue[i] = freeCurrentValue[i] = (ushort)i;
                quickBreakTime[i] = freeCurrentTime[i] = overCurrentTime[i] = flashyFlowTime[i] = (ushort)i;
                indtrAdds[i] = rate[i] = bandWidth[i] = tgz[i] = tfgs[i] = res3[i] = res4[i] = (ushort)i;

                calibration[i] = manualReset[i] = res1[i]=res2[i]=(byte)i;
            }

            //初始化故障指示器地址
            indtrAdds = new ushort[9];
            for (int i = 0; i < 9; i++)
            {
                indtrAdds[i] = (byte)(i + 1);
            }
            //初始化故障指示器发送速率及带宽等参数
            MDMCFG0=new byte[9];    
            MDMCFG1=new byte[9];
            MDMCFG2=new byte[9];
            MDMCFG3=new byte[9];
            MDMCFG4=new byte[9];
            for (int i = 0; i < 9; i++)
            {
                MDMCFG0[i] = MDMCFG1[i] = MDMCFG2[i] = MDMCFG3[i] = MDMCFG4[i] = (byte)i;
            }

        }

    }
}
