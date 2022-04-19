function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
 
    var area = b / 7;
 
    areaResultado.innerHTML = "" + area;
   }