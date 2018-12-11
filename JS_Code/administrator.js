function a(i_a) {
    var i_aid = i_a.id.toString();
    //alert(i_aid);
    //if (i_aid == 'menu1' || i_aid == 'menu2' || i_aid == 'menu3') {
    //    
    //
    for(var i=1;i<7;i++){
        if (i_aid == "menu" + i) {
            for (var j = 1; j < 7; j++) {
                if (i == j) {
                    var a = document.getElementById('next' + j);
                    if (a.src.toString() == 'http://localhost:2407/libraryWeb/res/%E4%B8%8B%E4%B8%80%E6%AD%A5.png') {
                        a.src = 'res/向下.png';
                    } else {
                        a.src = 'res/下一步.png';
                    }
                } else {
                    var a = document.getElementById('next' + j);
                    a.src = 'res/下一步.png';
                }
            }
        }
    }
    
 }
