function startTime() {
    var today = new Date()  //获取客户机当前系统日期
    var y = today.getFullYear();
    var mon = today.getMonth()+1;
    var d = today.getDate();
    var h = today.getHours()
    var m = today.getMinutes() 
    var s = today.getSeconds()
    // 调用checkTime()函数，在小于10的数字前加0
    m = checkTime(m)
    s = checkTime(s)
    //设置层'txt'内容
    document.getElementById('time').innerHTML =y + "年" + mon + "月" + d + "日" + h + ":" + m + ":" + s
    //过500毫秒后再调用'startTime()'函数
    setTimeout('startTime()', 1000)
}
//如果i<10，就在数字前加0
    function checkTime(i) {
    if (i < 10)
    { i = "0" + i }
    return i
}  