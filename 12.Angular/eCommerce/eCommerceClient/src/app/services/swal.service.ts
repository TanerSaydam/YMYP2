import { Injectable } from '@angular/core';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root'
})
export class SwalService {

  constructor() { }

  toast(text: string, type: SweetAlertIcon = "success") {
    const Toast = Swal.mixin({
      toast: true,
      position: 'bottom-end',
      showConfirmButton: false,
      timer: 3000,
      timerProgressBar: true
    })
    Toast.fire(text, '', type)
  }

  fire(title: string = "",text: string = "",confirmButtonText: string = "", icon: SweetAlertIcon = "question", callBack: ()=> void) {
    Swal.fire({
      title: title,
      html: text,
      showCancelButton: true,
      cancelButtonText: "Vazgeç",
      showConfirmButton: true,
      confirmButtonText: confirmButtonText,
      icon: icon
    }).then(res => {
      if (res.isConfirmed) {
        callBack();
      }
    })
  }
}

export type SweetAlertIcon = 'success' | 'error' | 'warning' | 'info' | 'question'
