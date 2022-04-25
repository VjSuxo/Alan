function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    
    var x = 3;
    var cont = 0;
    for(var i = 1; i <= 365 ; i++){
        x=3*i;
        cont= cont+x;
    }
    areaResultado.innerHTML=cont;    
   }