function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a =  parseInt(prompt("Ingrese cnumero : "));
    var x = 0;
    for(var i = 1; i <= 10 ; i++){
        x = a*i;
      alert(i+"*"+a+" = "+x);
    }
    
 }