const actualizar = () =>{
    const texto_ingresado = document.getElementById("texto-ingresado");
    const editor = document.getElementById("editor");
    editor.srcdoc = texto_ingresado.value;
}