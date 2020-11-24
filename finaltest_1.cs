 //开启计时器
        //计时器
        System.Timers.Timer t = new System.Timers.Timer();
        private void StartTimmer()
        {
            /*开启计时器改变图片位置*/
            t.Interval = 1 * 100;//设置间隔时间，为毫秒； 
            t.Elapsed += new System.Timers.ElapsedEventHandler(Timer_ChangePos);//到达时间的时候执行事件；                
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；              
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
        }
          //改变位置
        private void Timer_ChangePos(object sender, System.Timers.ElapsedEventArgs e)
        {               
            Attach(iCarCoord);
            Invalidate(false);
        }