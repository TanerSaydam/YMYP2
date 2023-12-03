namespace NET8WebApiWithMongoDb.DTOs;

public sealed record TodoSaveDto(string Value);

public sealed record TodoRemoveDto(string _Id);

public sealed record TodoUpdateDto(string _Id, string Value);