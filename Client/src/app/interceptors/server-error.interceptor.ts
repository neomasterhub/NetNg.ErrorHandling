import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { IServerErrorModel } from "../models/server-error.model";

@Injectable()
export class ServerErrorInterceptor implements HttpInterceptor {
  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    return next.handle(request)
      .pipe(
        catchError((httpErrorResponse: HttpErrorResponse) => {
          if (httpErrorResponse.status === 500) {
            const serverError = httpErrorResponse.error as IServerErrorModel;

            // as a service
            console.error({serverError});
          }

          return throwError(() => httpErrorResponse);
        }),
      );
  }
}
