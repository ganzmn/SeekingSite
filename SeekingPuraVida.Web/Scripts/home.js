$(document).ready(function () {
    //$('#allBlogs').hide();
    //$('#blogNav').hide();
    loadFeaturedBlogs();
});

var path = "http://localhost:51716";

function loadFeaturedBlogs() {
    $.ajax({
        url: path + '/blogs/featured',
        type: 'GET',
        success: function (featuredBlogs) {
            var output = "";
            var modal = "";
            var i = 0;

            for (i; i < featuredBlogs.length; i++) {
                if (featuredBlogs[i].IsFeatured) {

                    output += '<div class="col-md-4 col-sm-6 portfolio-item"><a class="portfolio-link" data-toggle="modal" href="#portfolioModal' + featuredBlogs[i].BlogId+'"><div class="portfolio-hover"><div class="portfolio-hover-content"><i class="fa fa-plus fa-3x"></i></div></div><img class="img-fluid"' 
                    output += 'src = ' + featuredBlogs[i].FeatureImageLocation + ' alt = ""></a><div class="portfolio-caption">'
                    output += '<h4>' + featuredBlogs[i].Title + '</h4>' + '<p class="text-muted">' + featuredBlogs[i].SubTitle + '</p></div></div>'
                    modal += '<div class="portfolio-modal modal fade" id="portfolioModal' + featuredBlogs[i].BlogId + '" tabindex="-1" role="dialog" aria-hidden="true">'
                    modal += '<div class="modal-dialog">'
                    modal += '<div class="modal-content">'
                    modal += '<div class="close-modal" data-dismiss="modal">'
                    modal += '<div class="lr">'
                    modal += '<div class="rl"></div></div></div>'
                    modal += '<div class="container">'
                    modal += '<div class="row">'
                    modal += '<div class="col-lg-8 mx-auto">'
                    modal += '<div class="modal-body">'
                    modal += '<h2 class="text-uppercase text-center">' + featuredBlogs[i].Title + '</h2>'
                    modal += '<p class="item-intro text-muted text-center">' + featuredBlogs[i].SubTitle + '</p>'
                    modal += featuredBlogs[i].BlogBody
                    modal += '<ul class="list-inline">'
                    modal += '<li> By: ' + featuredBlogs[i].Author + '</li>'
                    modal += '<li> Date: ' + featuredBlogs[i].Date + '</li>'
                    modal += '<li> Country: ' + featuredBlogs[i].Country + '</li></ul>'
                    modal += '<div class="align: center"></div><button class="btn btn-primary" data-dismiss="modal" type="button">'
                    modal += '<i class="fa fa-times"></i>'
                    modal += 'Close Article'
                    modal += '</button></div></div></div></div></div></div></div>'
                }
            }
            $('#featuredBlogs').html(output);
            $('#portfolioModals').html(modal);
        },
        error: function (jqxhr, techstatus, errorthrow) {
            alert('error');
        }
    })
}

