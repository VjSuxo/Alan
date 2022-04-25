function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a = document.getElementById("A").value;
    var ea = parseInt(document.getElementById("EA").value);
    var b = document.getElementById("B").value;
    var eb = parseInt(document.getElementById("EB").value);
    var c = document.getElementById("C").value;
    var ec = parseInt(document.getElementById("EC").value);
    if(ea <= eb && ea <= ec ){ 
        areaResultado.innerHTML = "El menor es "+a;
    }
    else{
        if(eb <= ec ){
            areaResultado.innerHTML = "El menor es "+b;
        }
        else{
            areaResultado.innerHTML = "El menor es "+c;
        }
    }
   }