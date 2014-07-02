(function ($) {
    $.fn.progressbar = function (options) {
        var settings = $.extend({
            width: '300px',
            height: '25px',
            color: '#0ba1b5',
            padding: '0px',
            border: '1px solid #ddd'
        }, options);

        //Set css to container
        $(this).css({
            'width': settings.width,
            'border': settings.border,
            'border-radius': '5px',
            'overflow': 'hidden',
            'display': 'inline-block',
            'padding': settings.padding,
            'margin': '0px 10px 5px 5px'
        });

        // add progress bar to container
        var progressbar = $("<div></div>");
        //progressbar.css({
        //    'height': settings.height,
        //    'text-align': 'right',
        //    'vertical-align': 'middle',
        //    'color': '#fff',
        //    'width': '0px',
        //    'border-radius': '3px',
        //    'background-color': settings.color,
        //    'transition-duration':'5s',
        //    'transition-delay':'2s'
        //});

        progressbar.css({
            'height': settings.height,
            '-webkit-transition': 'width 6s ease-in-out',
            '-moz-transition': 'width 6s ease-in-out',
        '-ms-transition': 'width 6s ease-in-out',
        '-o-transition': 'width 6s ease-in-out',
        'transition': 'width 6s ease-in-out'
        });



        $(this).append(progressbar);

        this.progress = function (value) {
            var width = $(this).width() * value / 100;
            progressbar.width(width).html(value + "% ");
        }
        return this;
    };

}(jQuery));