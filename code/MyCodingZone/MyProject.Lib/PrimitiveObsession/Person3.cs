namespace MyProject.Lib.PrimitiveObsession;

public record Person3(Age2 Age);

// Simple record without validation (sometimes good enough)
public record Age2(int Value);
