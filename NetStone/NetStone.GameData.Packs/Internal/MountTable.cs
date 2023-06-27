// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FFXIV
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct MountTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static MountTable GetRootAsMountTable(ByteBuffer _bb) { return GetRootAsMountTable(_bb, new MountTable()); }
  public static MountTable GetRootAsMountTable(ByteBuffer _bb, MountTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MountTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FFXIV.Mount? Mounts(int j) { int o = __p.__offset(4); return o != 0 ? (FFXIV.Mount?)(new FFXIV.Mount()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MountsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FFXIV.Mount? MountsByKey(uint key) { int o = __p.__offset(4); return o != 0 ? FFXIV.Mount.__lookup_by_key(__p.__vector(o), key, __p.bb) : null; }

  public static Offset<FFXIV.MountTable> CreateMountTable(FlatBufferBuilder builder,
      VectorOffset MountsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    MountTable.AddMounts(builder, MountsOffset);
    return MountTable.EndMountTable(builder);
  }

  public static void StartMountTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddMounts(FlatBufferBuilder builder, VectorOffset MountsOffset) { builder.AddOffset(0, MountsOffset.Value, 0); }
  public static VectorOffset CreateMountsVector(FlatBufferBuilder builder, Offset<FFXIV.Mount>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateMountsVectorBlock(FlatBufferBuilder builder, Offset<FFXIV.Mount>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartMountsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FFXIV.MountTable> EndMountTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FFXIV.MountTable>(o);
  }
  public static void FinishMountTableBuffer(FlatBufferBuilder builder, Offset<FFXIV.MountTable> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedMountTableBuffer(FlatBufferBuilder builder, Offset<FFXIV.MountTable> offset) { builder.FinishSizePrefixed(offset.Value); }
};

public struct Mount : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static Mount GetRootAsMount(ByteBuffer _bb) { return GetRootAsMount(_bb, new Mount()); }
  public static Mount GetRootAsMount(ByteBuffer _bb, Mount obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Mount __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string NameEn { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameEnBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameEnBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameEnArray() { return __p.__vector_as_array<byte>(6); }
  public string NameFr { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameFrBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameFrBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameFrArray() { return __p.__vector_as_array<byte>(8); }
  public string NameDe { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameDeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetNameDeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetNameDeArray() { return __p.__vector_as_array<byte>(10); }
  public string NameJa { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameJaBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameJaBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameJaArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FFXIV.Mount> CreateMount(FlatBufferBuilder builder,
      uint Id = 0,
      StringOffset NameEnOffset = default(StringOffset),
      StringOffset NameFrOffset = default(StringOffset),
      StringOffset NameDeOffset = default(StringOffset),
      StringOffset NameJaOffset = default(StringOffset)) {
    builder.StartTable(5);
    Mount.AddNameJa(builder, NameJaOffset);
    Mount.AddNameDe(builder, NameDeOffset);
    Mount.AddNameFr(builder, NameFrOffset);
    Mount.AddNameEn(builder, NameEnOffset);
    Mount.AddId(builder, Id);
    return Mount.EndMount(builder);
  }

  public static void StartMount(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, uint Id) { builder.AddUint(0, Id, 0); }
  public static void AddNameEn(FlatBufferBuilder builder, StringOffset NameEnOffset) { builder.AddOffset(1, NameEnOffset.Value, 0); }
  public static void AddNameFr(FlatBufferBuilder builder, StringOffset NameFrOffset) { builder.AddOffset(2, NameFrOffset.Value, 0); }
  public static void AddNameDe(FlatBufferBuilder builder, StringOffset NameDeOffset) { builder.AddOffset(3, NameDeOffset.Value, 0); }
  public static void AddNameJa(FlatBufferBuilder builder, StringOffset NameJaOffset) { builder.AddOffset(4, NameJaOffset.Value, 0); }
  public static Offset<FFXIV.Mount> EndMount(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FFXIV.Mount>(o);
  }

  public static VectorOffset CreateSortedVectorOfMount(FlatBufferBuilder builder, Offset<Mount>[] offsets) {
    Array.Sort(offsets, (Offset<Mount> o1, Offset<Mount> o2) => builder.DataBuffer.GetUint(Table.__offset(4, o1.Value, builder.DataBuffer)).CompareTo(builder.DataBuffer.GetUint(Table.__offset(4, o2.Value, builder.DataBuffer))));
    return builder.CreateVectorOfTables(offsets);
  }

  public static Mount? __lookup_by_key(int vectorLocation, uint key, ByteBuffer bb) {
    int span = bb.GetInt(vectorLocation - 4);
    int start = 0;
    while (span != 0) {
      int middle = span / 2;
      int tableOffset = Table.__indirect(vectorLocation + 4 * (start + middle), bb);
      int comp = bb.GetUint(Table.__offset(4, bb.Length - tableOffset, bb)).CompareTo(key);
      if (comp > 0) {
        span = middle;
      } else if (comp < 0) {
        middle++;
        start += middle;
        span -= middle;
      } else {
        return new Mount().__assign(tableOffset, bb);
      }
    }
    return null;
  }
};


}
