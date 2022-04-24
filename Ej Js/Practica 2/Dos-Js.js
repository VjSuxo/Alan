function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
 
    if(b > 40){
        b = (b-40)*100;
        var x = b -40;
        x = x*200;
        b = b+x;
    }
    else{
        b = b*100;
    }
    areaResultado.innerHTML = b;
   }