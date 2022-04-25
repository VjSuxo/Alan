function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var x = 0;
    var a =  parseInt(prompt("Ingrese cantidad de alumnos : "));
    var aprobados = 0;
    var reprobados = 0;
    for(var i = 1; i <= a ; i++){
       x =  parseInt(prompt("Ingrese nota : "));
       if(x <=51){
        aprobados++;
       }
       else{
           reprobados++;
       }
    }
    

    areaResultado.innerHTML="La cantidad de aprobados es : "+aprobados+" La cantidad de reprobadis es :"+reprobados;    
   }