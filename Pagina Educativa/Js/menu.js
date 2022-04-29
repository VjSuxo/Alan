$(document).ready(function(){
    $(window).on('scroll',function(){
        var link = s('.navegador .dot');
        var top = $(window).scrollTop();

        $('sec').each(function(){
            var id = $(this).attr('id');
            var height = $(this).height();
            var offset = $(this).offset() -150;
            if(top >= offset && top < offset + height){
                link.removeClass('active');
                $('.navegador').find('[data-scroll="'+id+'"]').addClass('active')
            }
        })
    })
})