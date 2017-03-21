﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Table;
using Core.Models.Data;
using System;

namespace Bit.Core.Services
{
    public interface ICipherService
    {
        Task SaveAsync(CipherDetails cipher);
        Task DeleteAsync(Cipher cipher);
        Task SaveFolderAsync(Folder folder);
        Task DeleteFolderAsync(Folder folder);
        Task MoveSubvaultAsync(Cipher cipher, IEnumerable<Guid> subvaultIds, Guid userId);
        Task ImportCiphersAsync(List<Folder> folders, List<CipherDetails> ciphers,
            IEnumerable<KeyValuePair<int, int>> folderRelationships);
    }
}
