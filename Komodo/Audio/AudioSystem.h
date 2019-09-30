#pragma once

#include "IAudioSystem.h"

class AudioSystem : public IAudioSystem
{
public:
    AudioSystem()
    {
        this->m_initialized = true;
    }

    ~AudioSystem()
    {
        std::cout << "Successfully shutdown Audio System!\n";
    }
};