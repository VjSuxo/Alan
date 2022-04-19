function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
    var a = parseInt(document.getElementById("minuto").value);
    if(a != 0 ){
        b++;
    }
    var area = 10*b;
 
    areaResultado.innerHTML = "" + area;
   }