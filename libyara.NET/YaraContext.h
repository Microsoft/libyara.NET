#pragma once

#include <yara.h>

namespace libyaraNET {

    public ref class YaraContext
    {
    public:
        YaraContext()
        {
            auto result = yr_initialize();
        }

        ~YaraContext()
        {
            auto result = yr_finalize();
        }
    };
}
