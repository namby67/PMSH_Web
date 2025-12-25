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
//Hàm validation
/**
 * Áp dụng lỗi JSON vào form bất kỳ với Bootstrap validation
 * @param {Array} errors - Array {field, message} từ backend
 * @param {string} formSelector - selector của form/modal
 */
function applyValidationErrors(errors, formSelector) {
  // Reset các lỗi cũ
  $(
    `${formSelector} .form-control, ${formSelector} select, ${formSelector} textarea`
  ).removeClass("is-invalid");
  $(`${formSelector} .invalid-feedback`).text("");

  if (!errors || errors.length === 0) return;

  errors.forEach(function (err) {
    // Tìm input/select/textarea theo name
    let $field = $(`${formSelector} [name='${err.field}']`);
    if ($field.length) {
      $field.addClass("is-invalid");
      // Gán nội dung vào invalid-feedback ngay sau field
      $field.siblings(".invalid-feedback").text(err.message);
    }
  });
}
$(document).ready(function () {
  getBusinessDate();
});
