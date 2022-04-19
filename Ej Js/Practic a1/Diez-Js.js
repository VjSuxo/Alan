function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a = parseInt(document.getElementById("Velocidad").value);
    var b = parseInt(document.getElementById("Distancia").value);
    
    var area = b*a;
 
    areaResultado.innerHTML = "" + area;
   }