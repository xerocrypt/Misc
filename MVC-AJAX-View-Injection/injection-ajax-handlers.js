        $(document).ready(function () {

            $.ajax({
                type: "GET",
                cache: false,
                url: '/Home/MyView',
                dataType: "JSON",
                success: function (data) {
                    $("#myviewcard").html(data.view);
                }
            });

            $.ajax({
                type: "GET",
                cache: false,
                url: '/Home/AboutPage',
                dataType: "JSON",
                success: function (data) {
                    $("#aboutpagecard").html(data.view);
                }
            });

        });
