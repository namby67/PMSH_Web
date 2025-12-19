// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Hàm gọi để lấy business-date

function getBusinessDate(callback) {
  return $.ajax({
    url: "/Reservation/GetBusinessDate",
    type: "get",
    dataType: "json",
    success: function (result) {
      const businessDate = result.split("T")[0];
      $("[data-business-date]").each(function () {

        $(this).val(businessDate);
      });

      if (typeof callback === "function") {
        callback(businessDate);
      }
    },
    error: function (xhr) {
      console.error(" AJAX ERROR", xhr.status);
    },
  });
}
$(document).ready(function () {
  getBusinessDate();
});
