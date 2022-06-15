$(document).ready(function () {
    $.noConflict();
    $("#example").DataTable(
        {

            lengthChange: false,
            pageLength: 10,
            language:
                {
                    "paginate": {
                        "previous": "Geri",
                        "next": "İleri"
                    }
                }

        });
});