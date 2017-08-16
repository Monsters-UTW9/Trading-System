$('.form').find('input, textarea, select').on('keyup blur focus', function (e) {

    var $this = $(this),
        label = $this.prev('label');

    if (e.type === 'keyup') {
        if ($this.val() === '') {
            label.removeClass('active highlight');
        } else {
            label.addClass('active highlight');
        }
    } else if (e.type === 'blur') {
        if ($this.val() === '') {
            label.removeClass('active highlight');
        } else {
            label.removeClass('highlight');
        }
    } else if (e.type === 'focus') {

        if ($this.val() === '') {
            label.removeClass('highlight');
        }
        else if ($this.val() !== '') {
            label.addClass('highlight');
        }
    }

});

$('.profile-img-container img').click(function () {
    $('#image').click();
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#profileImg')
                .attr('src', e.target.result);

        };

        reader.readAsDataURL(input.files[0]);
    }
}


/* show color box*/

$('.color-option').fadeToggle();
$('.fa-icon').click(function () {
    $('.color-option').fadeToggle();
});
//change color on click
var colorLi = $('.option-box ul li')
colorLi
    .eq(0).css("background-color", "#FF0F65").end()
    .eq(1).css("background-color", "#2549BB");
// change syle color
colorLi.click(function () {

    $("link[href*='color']").attr("href", $(this).attr("data-value"));
});
$(function () {
    $('[data-toggle="tooltip"]').tooltip({
        trigger: 'hover'
    });

});
