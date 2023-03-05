import { IServerError } from "../activity-types/server-error";

export interface IErrorModel {
  errorStack: IServerError[],
}
