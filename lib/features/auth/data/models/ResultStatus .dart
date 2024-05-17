enum ResultStatus { loading, success, failed }

class Result<T> {
  final ResultStatus status;
  final T? data;
  final String? error;

  Result.loading() : status = ResultStatus.loading, data = null, error = null;

  Result.success(this.data) : status = ResultStatus.success, error = null;

  Result.failed(this.error) : status = ResultStatus.failed, data = null;

  bool get isLoading => status == ResultStatus.loading;
  bool get isSuccess => status == ResultStatus.success;
  bool get isFailed => status == ResultStatus.failed;

  @override
  String toString() {
    return 'Result{status: $status, data: $data, error: $error}';
  }
}
