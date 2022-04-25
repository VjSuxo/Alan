function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a = parseInt(document.getElementById("uno").value);
    
    var b = parseInt(document.getElementById("dos").value);
    var c = parseInt(document.getElementById("diez").value);
    var d = parseInt(document.getElementById("veinte").value);
    var e = parseInt(document.getElementById("cincuenta").value);
    var f = parseInt(document.getElementById("cien").value);
    var x = (a*1)+(b*2)+(c*10)+(d*20)+(e*50)+(f*100);
    

    areaResultado.innerHTML=x;    
   }