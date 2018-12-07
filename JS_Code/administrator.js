function a(i_a) {
    var i_aid = i_a.id.toString();
    //alert(i_aid);
    //if (i_aid == 'menu1' || i_aid == 'menu2' || i_aid == 'menu3') {
    //    
    //}
    if (i_aid == 'menu1') {

        var a = document.getElementById('next1');
        var b = document.getElementById('next2');
        if (a.src.toString() == 'http://localhost:2407/libraryWeb/res/%E4%B8%8B%E4%B8%80%E6%AD%A5.png') {
            a.src = 'res/向下.png';
        } else {
            a.src = 'res/下一步.png';
        }
        //alert(a.src.toString());
    } else if (i_aid == 'menu2') {
        //alert("222");
        var a = document.getElementById('next2');
        if (a.src.toString() == 'http://localhost:2407/libraryWeb/res/%E4%B8%8B%E4%B8%80%E6%AD%A5.png') {
            a.src = 'res/向下.png';
        } else {
            a.src = 'res/下一步.png';
        }
    } else if (i_aid == 'menu3') {
        //alert("333");
        var a = document.getElementById('next3');
        if (a.src.toString() == 'http://localhost:2407/libraryWeb/res/%E4%B8%8B%E4%B8%80%E6%AD%A5.png') {
            a.src = 'res/向下.png';
        } else {
            a.src = 'res/下一步.png';
        }
    }
    
 }
